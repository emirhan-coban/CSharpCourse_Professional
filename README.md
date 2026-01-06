# 🎓 C# Professional Course - Eğitim Kampı 501

C# programlama dilinde profesyonel seviyede geliştirme yapmak için hazırlanmış kapsamlı bir eğitim projesi. Bu proje, modern C# uygulamaları geliştirirken kullanılan ileri düzey teknikleri ve best practice'leri içermektedir.

## 📋 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Kullanılan Teknolojiler](#-kullanılan-teknolojiler)
- [Kurulum](#-kurulum)
- [Modüller ve Konular](#-modüller-ve-konular)
- [Proje Yapısı](#-proje-yapısı)
- [Örnek Kod Parçacıkları](#-örnek-kod-parçacıkları)
- [Öğrenilenler](#-öğrenilenler)
- [Kaynaklar](#-kaynaklar)
- [Katkıda Bulunma](#-katkıda-bulunma)
- [Lisans](#-lisans)

## 🎯 Proje Hakkında

Bu eğitim projesi, C# dilinde profesyonel düzeyde yazılım geliştirme becerilerini kazandırmak amacıyla hazırlanmıştır. Proje, temel C# bilgisine sahip geliştiricilerin ileri seviye konulara geçiş yapmasını sağlayan kapsamlı bir eğitim içeriği sunar.

### Hedef Kitle

- Orta-ileri seviye C# geliştiricileri
- Backend teknolojilerini derinlemesine öğrenmek isteyenler
- Enterprise seviyede uygulama geliştirmek isteyenler
- Clean Code ve SOLID prensiplerini uygulamak isteyenler
- Modern .NET ekosistemini öğrenmek isteyenler

## ✨ Özellikler

- ✅ İleri düzey C# programlama teknikleri
- ✅ Veritabanı yönetimi ve ORM kullanımı
- ✅ Asenkron programlama
- ✅ Design Patterns (Tasarım Desenleri)
- ✅ SOLID prensipleri
- ✅ Dependency Injection
- ✅ API geliştirme
- ✅ Unit Testing
- ✅ Clean Code yazım teknikleri
- ✅ Best practices ve kod standartları

## 🛠 Kullanılan Teknolojiler

| Teknoloji | Versiyon | Açıklama |
|-----------|----------|----------|
| **C#** | 10.0+ | Ana programlama dili |
| **.NET** | 6.0/7.0 | Framework |
| **Entity Framework Core** | Latest | ORM aracı |
| **SQL Server** | 2019+ | Veritabanı sistemi |
| **Dapper** | Latest | Micro ORM |
| **AutoMapper** | Latest | Object mapping |
| **xUnit/NUnit** | Latest | Unit testing framework |
| **Moq** | Latest | Mocking library |
| **Serilog** | Latest | Logging framework |

## 📦 Kurulum

### Gereksinimler

- Visual Studio 2022 (Community, Professional veya Enterprise)
- .NET 6.0 SDK veya üzeri
- SQL Server 2019 veya üzeri (SQL Server Express yeterli)
- Git

### Adım Adım Kurulum

1. **Projeyi Klonlama**

   ```bash
   git clone https://github.com/emirhan-coban/CSharpCourse_Professional.git
   cd CSharpCourse_Professional
   ```

2. **Solution'ı Açma**

   ```bash
   # Visual Studio ile açmak için
   start CSharpEgitimKampi501.slnx
   
   # Veya Visual Studio'dan File > Open > Project/Solution
   ```

3. **NuGet Paketlerini Restore Etme**

   ```bash
   dotnet restore
   ```

4. **Veritabanı Bağlantısını Yapılandırma**

   `appsettings.json` dosyasında connection string'i düzenleyin:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=CSharpCourse;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }
   ```

5. **Veritabanı Migration**

   ```bash
   dotnet ef database update
   ```

6. **Projeyi Çalıştırma**

   ```bash
   dotnet run
   ```

## 📚 Modüller ve Konular

### 1. İleri Düzey C# Özellikleri

```csharp
// Records
public record Product(int Id, string Name, decimal Price);

// Pattern Matching
var result = shape switch
{
    Circle c => c.Radius * c.Radius * Math.PI,
    Rectangle r => r.Width * r.Height,
    _ => 0
};

// Nullable Reference Types
string? nullableString = null;
string nonNullableString = "Hello";
```

### 2. LINQ ve Lambda Expressions

```csharp
// Complex LINQ Queries
var result = products
    .Where(p => p.Price > 100)
    .OrderBy(p => p.Name)
    .GroupBy(p => p.Category)
    .Select(g => new
    {
        Category = g.Key,
        Count = g.Count(),
        AveragePrice = g.Average(p => p.Price)
    });

// Method Chaining
var topProducts = repository
    .GetAll()
    .AsEnumerable()
    .Where(p => p.IsActive)
    .OrderByDescending(p => p.SalesCount)
    .Take(10);
```

### 3. Asenkron Programlama

```csharp
// Async/Await
public async Task<List<Product>> GetProductsAsync()
{
    return await _context.Products
        .Where(p => p.IsActive)
        .ToListAsync();
}

// Parallel Processing
await Task.WhenAll(
    ProcessOrderAsync(order1),
    ProcessOrderAsync(order2),
    ProcessOrderAsync(order3)
);

// CancellationToken
public async Task<Data> FetchDataAsync(CancellationToken cancellationToken)
{
    return await _httpClient.GetFromJsonAsync<Data>(
        "api/data", 
        cancellationToken
    );
}
```

### 4. Repository Pattern

```csharp
// Generic Repository Interface
public interface IRepository<T> where T : class
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(int id);
}

// Implementation
public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }
    
    // Diğer metodlar...
}
```

### 5. Dependency Injection

```csharp
// Service Registration
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}

// Constructor Injection
public class ProductService : IProductService
{
    private readonly IRepository<Product> _repository;
    private readonly ILogger<ProductService> _logger;

    public ProductService(
        IRepository<Product> repository,
        ILogger<ProductService> logger)
    {
        _repository = repository;
        _logger = logger;
    }
}
```

### 6. Design Patterns

```csharp
// Singleton Pattern
public sealed class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> _instance = 
        new Lazy<ConfigurationManager>(() => new ConfigurationManager());
    
    public static ConfigurationManager Instance => _instance.Value;
    
    private ConfigurationManager() { }
}

// Factory Pattern
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class PaymentProcessorFactory
{
    public IPaymentProcessor CreateProcessor(PaymentType type)
    {
        return type switch
        {
            PaymentType.CreditCard => new CreditCardProcessor(),
            PaymentType.PayPal => new PayPalProcessor(),
            PaymentType.BankTransfer => new BankTransferProcessor(),
            _ => throw new ArgumentException("Invalid payment type")
        };
    }
}

// Strategy Pattern
public interface IPricingStrategy
{
    decimal CalculatePrice(decimal basePrice);
}

public class SeasonalDiscountStrategy : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice)
    {
        return basePrice * 0.8m; // %20 indirim
    }
}
```

### 7. Exception Handling ve Logging

```csharp
// Global Exception Handler
public class GlobalExceptionHandler : IExceptionHandler
{
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public async Task<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        _logger.LogError(exception, "An error occurred: {Message}", exception.Message);

        var response = new ErrorResponse
        {
            StatusCode = exception is NotFoundException ? 404 : 500,
            Message = exception.Message,
            Timestamp = DateTime.UtcNow
        };

        httpContext.Response.StatusCode = response.StatusCode;
        await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);

        return true;
    }
}

// Structured Logging with Serilog
Log.Information("User {UserId} accessed {Resource} at {Timestamp}", 
    userId, resource, DateTime.Now);
```

### 8. Unit Testing

```csharp
// xUnit Test Example
public class ProductServiceTests
{
    private readonly Mock<IRepository<Product>> _mockRepository;
    private readonly ProductService _service;

    public ProductServiceTests()
    {
        _mockRepository = new Mock<IRepository<Product>>();
        _service = new ProductService(_mockRepository.Object);
    }

    [Fact]
    public async Task GetProductById_ReturnsProduct_WhenProductExists()
    {
        // Arrange
        var expectedProduct = new Product { Id = 1, Name = "Test Product" };
        _mockRepository
            .Setup(r => r.GetByIdAsync(1))
            .ReturnsAsync(expectedProduct);

        // Act
        var result = await _service.GetProductByIdAsync(1);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedProduct.Name, result.Name);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public async Task GetProductById_ThrowsException_WhenIdIsInvalid(int id)
    {
        // Act & Assert
        await Assert.ThrowsAsync<ArgumentException>(
            () => _service.GetProductByIdAsync(id)
        );
    }
}
```

## 📁 Proje Yapısı

```
CSharpCourse_Professional/
│
├── CSharpEgitimKampi501/
│   │
│   ├── Core/
│   │   ├── Entities/              # Domain modelleri
│   │   ├── Interfaces/            # Interface tanımlamaları
│   │   └── DTOs/                  # Data Transfer Objects
│   │
│   ├── Infrastructure/
│   │   ├── Data/                  # DbContext ve migrations
│   │   ├── Repositories/          # Repository implementasyonları
│   │   └── Services/              # Business logic servisleri
│   │
│   ├── Application/
│   │   ├── Services/              # Application servisleri
│   │   ├── Mapping/               # AutoMapper profilleri
│   │   └── Validators/            # FluentValidation
│   │
│   ├── Presentation/
│   │   ├── Controllers/           # API Controllers (varsa)
│   │   └── Program.cs             # Entry point
│   │
│   ├── Tests/
│   │   ├── UnitTests/             # Birim testleri
│   │   └── IntegrationTests/      # Entegrasyon testleri
│   │
│   └── Utilities/
│       ├── Helpers/               # Yardımcı sınıflar
│       └── Extensions/            # Extension metodları
│
├── .gitignore
├── .gitattributes
├── CSharpEgitimKampi501.slnx      # Solution dosyası
└── README.md
```

## 💻 Örnek Kod Parçacıkları

### Entity Örneği

```csharp
public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    
    // Navigation Properties
    public virtual Category Category { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
}

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public bool IsActive { get; set; } = true;
}
```

### Service Layer Örneği

```csharp
public class ProductService : IProductService
{
    private readonly IRepository<Product> _productRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<ProductService> _logger;

    public ProductService(
        IRepository<Product> productRepository,
        IMapper mapper,
        ILogger<ProductService> logger)
    {
        _productRepository = productRepository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<ProductDto> GetByIdAsync(int id)
    {
        try
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                _logger.LogWarning("Product with ID {Id} not found", id);
                throw new NotFoundException($"Product with ID {id} not found");
            }

            return _mapper.Map<ProductDto>(product);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting product {Id}", id);
            throw;
        }
    }

    public async Task<List<ProductDto>> GetAllActiveAsync()
    {
        var products = await _productRepository
            .GetAll()
            .Where(p => p.IsActive)
            .ToListAsync();
            
        return _mapper.Map<List<ProductDto>>(products);
    }

    public async Task<ProductDto> CreateAsync(CreateProductDto dto)
    {
        var product = _mapper.Map<Product>(dto);
        product.CreatedAt = DateTime.Now;

        await _productRepository.AddAsync(product);
        
        _logger.LogInformation("Product created: {Name}", product.Name);
        
        return _mapper.Map<ProductDto>(product);
    }
}
```

### AutoMapper Profile

```csharp
public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>()
            .ForMember(dest => dest.CategoryName, 
                opt => opt.MapFrom(src => src.Category.Name));
                
        CreateMap<CreateProductDto, Product>();
        CreateMap<UpdateProductDto, Product>();
    }
}
```

### Extension Methods

```csharp
public static class StringExtensions
{
    public static string ToTitleCase(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;
            
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
    }

    public static bool IsValidEmail(this string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        try
        {
            var addr = new MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}

public static class DateTimeExtensions
{
    public static bool IsWeekend(this DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday || 
               date.DayOfWeek == DayOfWeek.Sunday;
    }

    public static DateTime StartOfWeek(this DateTime date)
    {
        int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
        return date.AddDays(-1 * diff).Date;
    }
}
```

## 📚 Öğrenilenler

Bu proje ile şu konularda derinlemesine bilgi ve deneyim kazanılır:

### Temel Konular
- C# 10+ özelliklerinin kullanımı (Records, Pattern Matching, etc.)
- LINQ ve Lambda expressions ile veri manipülasyonu
- Asenkron programlama best practices
- Exception handling ve error management
- Logging ve monitoring

### Mimari ve Tasarım
- Clean Architecture prensipleri
- SOLID prensiplerinin uygulanması
- Design Patterns implementasyonu
- Dependency Injection ve IoC
- Repository ve Unit of Work pattern

### Veritabanı
- Entity Framework Core ile ORM
- Complex query yazımı
- Migration yönetimi
- Performance optimization
- Database seeding ve initialization

### Test
- Unit testing metodolojileri
- Mocking ve test doubles
- Test-Driven Development (TDD)
- Integration testing
- Code coverage

### Best Practices
- Clean Code prensipleri
- Code organization ve structure
- Naming conventions
- Documentation
- Performance optimization

## 🔗 Kaynaklar

### Resmi Dokümantasyon
- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/)

### Öğrenme Kaynakları
- [C# Design Patterns](https://refactoring.guru/design-patterns/csharp)
- [Clean Code by Robert C. Martin](https://www.amazon.com/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882)
- [Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/)
- [Pluralsight C# Path](https://www.pluralsight.com/paths/c-10)

### Topluluk ve Forum
- [Stack Overflow - C#](https://stackoverflow.com/questions/tagged/c%23)
- [Reddit r/csharp](https://www.reddit.com/r/csharp/)
- [C# Discord Community](https://discord.gg/csharp)
- [.NET Foundation](https://dotnetfoundation.org/)

### Araçlar
- [Visual Studio](https://visualstudio.microsoft.com/)
- [ReSharper](https://www.jetbrains.com/resharper/)
- [LINQPad](https://www.linqpad.net/)
- [dotnet CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/)

## 🤝 Katkıda Bulunma

Katkılarınızı memnuniyetle karşılıyoruz! Projeye katkıda bulunmak için:

1. **Fork** yapın
2. Feature branch oluşturun
   ```bash
   git checkout -b feature/amazing-feature
   ```
3. Değişikliklerinizi commit edin
   ```bash
   git commit -m 'feat: Add amazing feature'
   ```
4. Branch'inizi push edin
   ```bash
   git push origin feature/amazing-feature
   ```
5. **Pull Request** açın

### Commit Mesajı Standartları

- `feat:` Yeni özellik
- `fix:` Bug düzeltmesi
- `docs:` Dokümantasyon değişikliği
- `style:` Kod formatı değişikliği
- `refactor:` Kod refactoring
- `test:` Test ekleme veya düzenleme
- `chore:` Build veya araç değişiklikleri

## 📄 Lisans

Bu proje eğitim amaçlı olarak hazırlanmıştır ve açık kaynak kodludur. 

## 🏆 Başarım Rozetleri

- ✅ Clean Code Principles
- ✅ SOLID Implementation
- ✅ Design Patterns
- ✅ Test Coverage > 80%
- ✅ Best Practices

## 👨‍💻 Geliştirici

**Emirhan ÇOBAN**
- GitHub: [@emirhan-coban](https://github.com/emirhan-coban)

---

## 📞 İletişim

Sorularınız veya önerileriniz için:
- Issue açabilirsiniz
- Pull request gönderebilirsiniz
- Discussions bölümünü kullanabilirsiniz

---

<div align="center">

**⭐ Bu projeyi faydalı bulduysanız yıldız vermeyi unutmayın!**

**Happy Coding! 🚀**
