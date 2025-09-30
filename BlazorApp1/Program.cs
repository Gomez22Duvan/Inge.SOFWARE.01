using BlazorApp1.Components;

var builder = WebApplication.CreateBuilder(args);
var url = "https://mrbsvfacogbutropmsqy.supabase.co";
var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im1yYnN2ZmFjb2didXRyb3Btc3F5Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTg1ODQ0MDEsImV4cCI6MjA3NDE2MDQwMX0.D1MM9dTfA8agkPQZoTpl65b5PPbfd1NP8vxG0OUsKbA";

var options = new Supabase.SupabaseOptions
{
    AutoConnectRealtime = true
};

var supabase = new Supabase.Client(url, key, options);
await supabase.InitializeAsync();
builder.Services.AddSingleton(supabase);
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
