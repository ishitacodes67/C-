// REST API with File Upload/Download 
// This code demonstrates how to create a REST API for file upload and download using ASP.NET Core.
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// ------------------ SWAGGER ------------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "File Upload/Download API",
        Version = "v1"
    });
});

var app = builder.Build();

// ------------------ MIDDLEWARE ------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ------------------ FILE STORAGE PATH ------------------
var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");

// Ensure folder exists
if (!Directory.Exists(uploadPath))
{
    Directory.CreateDirectory(uploadPath);
}

// ------------------ ENDPOINTS ------------------

// Upload file
app.MapPost("/upload", async (IFormFile file) =>
{
    if (file == null || file.Length == 0)
        return Results.BadRequest("No file uploaded.");

    var filePath = Path.Combine(uploadPath, file.FileName);

    using (var stream = new FileStream(filePath, FileMode.Create))
    {
        await file.CopyToAsync(stream);
    }

    return Results.Ok(new
    {
        Message = "File uploaded successfully",
        FileName = file.FileName
    });
})
.Accepts<IFormFile>("multipart/form-data");

// Download file
app.MapGet("/download/{fileName}", (string fileName) =>
{
    var filePath = Path.Combine(uploadPath, fileName);

    if (!System.IO.File.Exists(filePath))
        return Results.NotFound("File not found.");

    var contentType = "application/octet-stream";
    var fileBytes = System.IO.File.ReadAllBytes(filePath);

    return Results.File(fileBytes, contentType, fileName);
});

// Get all uploaded files
app.MapGet("/files", () =>
{
    var files = Directory.GetFiles(uploadPath)
                         .Select(Path.GetFileName)
                         .ToList();

    return Results.Ok(files);
});

app.Run();
