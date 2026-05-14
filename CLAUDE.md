# StudioEmin (PhotoEmin) - Proje Rehberi

## Proje Tanımı
Stüdyo Emin Fotoğrafçılık için geliştirilmiş, fotoğraf stüdyosu müşteri yönetim ve makbuz/arşiv sistemi uygulaması.  
**Teknoloji:** .NET 8.0, WinForms, PostgreSQL (Npgsql), C#

## Çözüm Yapısı
```
StudioEmin/
├── StudioEmin.sln              # Ana solution dosyası
└── PhotoEmin/                  # Ana proje dizini
    ├── PhotoEmin.csproj        # .NET 8.0-windows, WinForms
    ├── Program.cs              # Giriş noktası → Form1
    ├── Form1.cs                # ~2944 satır - TÜM uygulama mantığı (monolithic)
    ├── Form1.Designer.cs       # ~2381 satır - UI bileşenleri tanımları
    ├── Form1.resx              # Form kaynakları
    ├── app.manifest            # UAC: asInvoker
    ├── Model/
    │   ├── Receipt.cs           # Makbuz veri modeli + dosya okuyucu
    │   ├── ArchiveExplanations.cs # Arşiv açıklama sabitleri
    │   └── RecordStatus.cs      # Toplu kayıt sonuç durumu
    ├── Extensions/
    │   ├── Resources.resx       # Gömülü kaynak tanımları (41 resim)
    │   └── Resources.Designer.cs # Otomatik üretilmiş kaynak erişimi
    ├── Resources/               # 41 adet görsel kaynak dosyası (PNG, JPG, GIF, ICO)
    └── Properties/
        └── PublishProfiles/     # Yayın profilleri
```

## NuGet Bağımlılıkları
- `Npgsql 8.0.1` — PostgreSQL veritabanı istemcisi
- `Microsoft.Data.SqlClient 5.2.0` — (Yorum satırında, MS SQL desteği için)
- `System.Management 8.0.0` — Windows WMI erişimi (disk seri no vb.)

## Veritabanı
- **Sunucu:** PostgreSQL (localhost:5432)
- **Veritabanı adı:** `dbphoto`
- **Tablo:** `customers`
  - `id` BIGSERIAL PK
  - `fullname` TEXT NOT NULL
  - `foldername` TEXT
  - `photodata` BYTEA (küçültülmüş thumbnail, 118×118)
  - `createdate` TIMESTAMPTZ
  - `insertdate` TIMESTAMPTZ
- **Kullanıcı:** postgres / postgres

## Uygulama Modülleri

### 1. Makbuz Sistemi (pnlReceipt)
- Müşteri Ad-Soyad, Ebat, Adet, Tutar/Alınan/Kalan hesaplaması
- Klasöre kayıt (müşteri adıyla klasör + txt dosya)
- Termal yazıcıya doğrudan yazdırma (240px genişlik)

### 2. Dosya/Klasör Arama (pnlFindFolder)
- Sürücü seçimi + klasör adı ile recursive arama
- Ayrı thread'de arama (UI donmaz)
- Sonuçlara çift tıklayarak Explorer'da açma

### 3. Arşiv Yönetimi (flowLayoutPanelArchive)
- **Fotoğraf Ara:** DB'de isim araması, thumbnail görüntüleme
- **Klasörleri Arşive Ekle:** Alt klasörleri tarayıp DB'ye kaydet
- **Üst Klasörleri Arşive Ekle:** İç içe klasör yapısını toplu kaydet
- **Yedekle (DB→Dosya):** Tüm kayıtları JPEG olarak dışa aktar
- **Yedek→Arşiv:** `AdSoyad_KlasörAdı.jpg` formatındaki yedekleri geri yükle

### 4. DB İşlemleri (pnlDBprocess)
- DB oluştur / sil / yedek al (pg_dump .tar) / yedek yükle (pg_restore)
- Şifre korumalı (wingman / emin)

## Türkçe Karakter Yönetimi
- Arama sorgusu: `UPPER(REPLACE(REPLACE(fullname, 'i', 'İ'), 'ı', 'I'))` — SQL tarafında Türkçe i/I dönüşümü
- C# tarafı: `new CultureInfo("tr-TR")` ile `ToUpper()`

## Sabit Şifreler
- DB işlemleri: `"wingman"`
- Silme/güncelleme: `"emin"`

## Build & Çalıştırma
```bash
dotnet build PhotoEmin/PhotoEmin.csproj
dotnet run --project PhotoEmin/PhotoEmin.csproj
```

## Önemli Notlar
- Form boyutu: 1720×975 piksel (sabit, responsive değil)
- Tüm iş mantığı tek Form1.cs dosyasında (~2944 satır)
- MSSQL desteği yorum satırı olarak tüm metotlarda mevcut (#region msSql)
- Yedek/Geri yükleme PostgreSQL kurulum dizinini otomatik algılar
- `_` (alt çizgi) karakteri ayırıcı olarak kullanılır: `AdSoyad_KlasörAdı`
