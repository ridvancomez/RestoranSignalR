# RestoranSignalR

ASP.NET Core ve SignalR ile geliştirilmiş gerçek zamanlı restoran yönetim sistemi.

---

## Özellikler

- Gerçek zamanlı masa, sipariş ve sepet güncellemeleri (SignalR)
- Menü, kategori ve ürün yönetimi
- Masa rezervasyonu (Booking)
- İndirim ve kasa (MoneyCase) yönetimi
- Bildirim sistemi
- Rol bazlı yetkilendirme (Admin / Garson)
- AutoMapper ile DTO katmanı

---

## Mimari

```
RestoranSignalR/
├── SignalRApi               # REST API + SignalR Hubs
├── SignalRWebUI             # MVC — kullanıcı arayüzü
├── SignalR.BusinessLayer    # İş mantığı (Abstract + Concrete)
├── SignalR.DataAccessLayer  # Veri erişimi (Repository Pattern)
├── SignalR.DTOLayer         # Data Transfer Objects
└── EntityLayer              # Entity sınıfları
```

---

## Teknoloji

| | |
|---|---|
| Framework | ASP.NET Core |
| Gerçek Zamanlı | SignalR (Hubs) |
| ORM | Entity Framework Core (Code First) |
| Veritabanı | MSSQL |
| Mimari | N-Tier, Repository Pattern, Strategy Pattern, DI |
| Mapping | AutoMapper |

---

## Kurulum

**Gereksinimler:** .NET SDK, MSSQL Server

```bash
git clone https://github.com/ridvancomez/RestoranSignalR.git
```

`SignalRApi/appsettings.json` dosyasındaki connection string'i güncelle, ardından:

```bash
cd SignalRApi
dotnet ef database update
dotnet run
```

UI için ayrı terminalde:

```bash
cd SignalRWebUI
dotnet run
```

> ⚠️ Proje geliştirme aşamasındadır.
