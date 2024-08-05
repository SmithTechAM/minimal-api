var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/login",(minimal_api.DTOs.LoginDto loginDto) =>{
    if(loginDto.Email == "adm@teste.com" && loginDto.Senha =="123456")
        return Results.Ok("Login com sucesso");
    else
        return Results.Unauthorized();
});

app.Run();

