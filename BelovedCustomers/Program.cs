using BelovedCustomers.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registering address services depending on app configuration (customer specific)
if (builder.Configuration["AddressService"] == "Premium")
{
    builder.Services.AddScoped<IAddressService, PremiumCustomerAddressService>();
}
else
{
    builder.Services.AddScoped<IAddressService, DefaultAddressService>();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
