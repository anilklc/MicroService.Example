# MicroService.Example

MicroService.Example, temel mikro servis mimarisi prensiplerini öğrenmek ve uygulamak amacıyla geliştirilmiş bir projedir. Bu proje, API Gateway (Ocelot), JWT kimlik doğrulama, Ocelot caching, load balancing, rate limiting ve temel mikro servis iletişimini içermektedir.

## Özellikler

- **API Gateway**: Ocelot kullanılarak mikro hizmetlere yönlendirme ve API Gateway işlevselliği.
- **Kimlik Doğrulama ve Yetkilendirme**: JWT tabanlı kimlik doğrulama ile güvenli erişim.
- **Ocelot Caching**: Ocelot tarafından sağlanan önbellekleme ile performans iyileştirmesi.
- **Load Balancing**: Ocelot'un desteklediği yük dengeleme ile isteklerin birden fazla mikro hizmet arasında dağıtılması.
- **Rate Limiting**: Ocelot tarafından sağlanan rate limiting ile isteklerin kontrolü ve sınırlanması.
- **Logging**: Konsol loglama kullanılarak merkezi loglama.
- **Mikro Servis İletişimi**: Servisler arası iletişim ve veri alışverişi.

## Kullanılan Teknolojiler

- ASP.NET Core
- Ocelot API Gateway
- JWT Kimlik Doğrulama
- Ocelot Caching
- Ocelot Load Balancing
- Ocelot Rate Limiting
- Konsol Loglama
- .NET Core 8

## Başlarken

### Gereksinimler

- .NET 8 SDK

### Kurulum

1. Depoyu klonlayın:
    ```sh
    git clone https://github.com/anilklc/MicroService.Example.git
    ```
2. Proje dizinine gidin:
    ```sh
    cd MicroService.Example
    ```
3. API Gateway ve mikro servislerin yapılandırmalarını `appsettings.json` dosyasında güncelleyin.
4. Ocelot caching, load balancing ve rate limiting yapılandırmalarını `ocelot.json` dosyasında kontrol edin ve gerekirse değişiklik yapın.
5. Uygulamayı çalıştırın:
    ```sh
    dotnet run
    ```


### Ekran Görüntüleri

![Screenshot 1](Screenshots/1.png)
![Screenshot 2](Screenshots/2.png)
![Screenshot 3](Screenshots/3.png)
![Screenshot 4](Screenshots/4.png)
![Screenshot 5](Screenshots/5.png)
![Screenshot 6](Screenshots/6.png)

### Lisans

Bu proje MIT Lisansı altında lisanslanmıştır.
