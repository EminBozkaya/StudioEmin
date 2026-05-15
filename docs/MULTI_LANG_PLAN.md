# StudioEmin - Çoklu Dil Desteği Uygulama Planı

**Tarih:** 2026-05-15  
**Branch:** `refactorMultiLang`  
**Yaklaşım:** JSON tabanlı dil dosyaları + dinamik dil keşfi + uygulama yeniden başlatma

---

## 1. Genel Mimari

### 1.1 Dil Dosyaları Konumu
```
PhotoEmin/
└── Languages/
    ├── tr.json    (Türkçe - varsayılan)
    └── en.json    (İngilizce)
```

### 1.2 Dinamik Dil Keşfi
- Uygulama başlarken `Languages/` klasöründeki tüm `*.json` dosyalarını tarar
- Her JSON dosyasının içinde `"_languageName"` key'i bulunur (örn: `"Türkçe"`, `"English"`, `"Français"`)
- Bu sayede birisi `fr.json` dosyasını koyduğunda, dropdown otomatik olarak "Français" seçeneğini gösterir
- Yeni dil eklemek için sadece yeni bir JSON dosyası oluşturmak yeterlidir

### 1.3 Dil Seçimi Saklama
- Seçilen dil `appsettings.json` dosyasına veya ayrı bir `language.config` dosyasına kaydedilir
- Uygulama açılışında bu ayar okunur ve ilgili JSON yüklenir
- Dil değiştiğinde kullanıcıya "Dil değişikliğinin uygulanması için program yeniden başlatılacaktır" mesajı gösterilir ve `Application.Restart()` çağrılır

### 1.4 Dil Değiştirme Akışı
```
Kullanıcı dropdown'dan dil seçer
  → Seçim config dosyasına yazılır
  → MessageBox: "Dil değişikliği için uygulama yeniden başlatılacaktır"
  → Application.Restart()
  → Uygulama açılır, config'den dil okunur
  → JSON yüklenir, tüm UI elemanları güncellenir
```

---

## 2. Oluşturulacak Yeni Dosyalar ve Sınıflar

### 2.1 `LanguageManager.cs` (Helpers klasörüne)
```csharp
// Sorumlulukları:
// - Languages/ klasöründen JSON dosyalarını keşfetme
// - Mevcut dil JSON'ını yükleme (Dictionary<string, string>)
// - Anahtar ile çeviri döndürme: GetString("key") veya ["key"]
// - Mevcut dil bilgisini saklama/okuma (config dosyasından)
// - Kullanılabilir dillerin listesini döndürme
```

**Temel Metotlar:**
| Metot | Açıklama |
|-------|----------|
| `static void Initialize()` | Languages klasörünü tarar, config'den dili okur, JSON'ı yükler |
| `static string GetString(string key)` | Çeviri döner; bulunamazsa key'in kendisini döner |
| `static List<LanguageInfo> GetAvailableLanguages()` | Mevcut dil dosyalarını döner (code + name) |
| `static string CurrentLanguage` | Şu anki dil kodu (tr, en, fr vb.) |
| `static void SetLanguage(string langCode)` | Config'e yazar |

### 2.2 `LanguageInfo.cs` (Model klasörüne)
```csharp
public class LanguageInfo
{
    public string Code { get; set; }     // "tr", "en", "fr"
    public string Name { get; set; }     // "Türkçe", "English", "Français"
    public string FilePath { get; set; } // tam dosya yolu
}
```

### 2.3 `tr.json` ve `en.json` (Languages klasörüne)
JSON yapısı aşağıda Bölüm 3'te detaylandırılmıştır.

---

## 3. JSON Dil Dosyası Yapısı ve Çeviri Haritası

### 3.1 JSON Genel Yapısı
```json
{
  "_languageName": "Türkçe",
  "_languageCode": "tr",
  
  "app_title": "Stüdyo-emin",
  
  "nav_myComputer": "Bilgisayarım",
  "nav_findFolder": "Klasör Ara",
  "nav_createReceipt": "Makbuz Kes",
  "nav_archive": "Arşiv",
  "nav_database": "Veri Tabanı",
  "nav_language": "Dil",
  
  "receipt_xxx": "...",
  "find_xxx": "...",
  "archive_xxx": "...",
  "db_xxx": "...",
  "msg_xxx": "...",
  "pwd_xxx": "...",
  "lang_xxx": "..."
}
```

### 3.2 Tam Çeviri Haritası

Aşağıda projede çevirilmesi gereken **tüm** metinler kategorize edilmiştir.

---

#### 3.2.1 Form Başlığı ve Ana Navigasyon

| JSON Key | Kaynak | TR | EN |
|----------|--------|----|----|
| `app_title` | Form1.Text | Stüdyo-emin | Studio Emin |
| `nav_myComputer` | lblBilgisayarım.Text | Bilgisayarım | My Computer |
| `nav_findFolder` | lblKlasörAra.Text | Klasör Ara | Find Folder |
| `nav_createReceipt` | lblMakbuzKes.Text | Makbuz Kes | Create Receipt |
| `nav_archive` | lblArşiv.Text | Arşiv | Archive |
| `nav_database` | lblVeriTabanı.Text | Veri Tabanı | Database |

---

#### 3.2.2 Makbuz Paneli (pnlReceipt)

| JSON Key | Kaynak | TR | EN |
|----------|--------|----|----|
| `receipt_name` | lblName.Text | Ad - Soyad: | Full Name: |
| `receipt_dimensions` | lblEbat.Text | Ebat: | Size: |
| `receipt_quantity` | lblAdet.Text | Adet: | Qty: |
| `receipt_total` | lblTutar.Text | Tutar: | Total: |
| `receipt_received` | lblAlınan.Text | Alınan: | Received: |
| `receipt_remaining` | lblKalan.Text | Kalan: | Remaining: |
| `receipt_deliveryDate` | lblTeslimTarihi.Text | Teslim Tarihi: | Delivery Date: |
| `receipt_notes` | lblNot.Text | Not: | Notes: |
| `receipt_nameWarning` | lblAdSoyadkısmındaaltçizgi_KULLANMAYINIZ.Text | 'Ad Soyad' kısmında alt çizgi '_' KULLANMAYINIZ! | Do NOT use underscore '_' in the Name field! |
| `receipt_selectedLocation` | lblSeçilenKonum.Text | Seçilen Konum: | Selected Location: |
| `receipt_createdReceipt` | lblReceiptCaption.Text | Oluşturulan Makbuz: | Created Receipt: |
| `receipt_folder` | lblKlasör.Text | Klasör           : | Folder          : |
| `receipt_receiptName` | lblMakbuzAdı.Text | Makbuz Adı: | Receipt Name: |
| `receipt_goToFolder` | lblKlasöreGit.Text | Klasöre Git | Go to Folder |
| `receipt_goToReceipt` | lblMakbuzaGit.Text | Makbuza Git | Go to Receipt |
| `receipt_save` | lblSave.Text | Kaydet | Save |
| `receipt_saveAndPrint` | lblSaveAndPrint.Text | Kaydet ve Yazdır | Save and Print |
| `receipt_print` | lblYazdır.Text | Yazdır | Print |
| `receipt_clearForm` | lblFormuTemizle.Text | Formu Temizle | Clear Form |
| `receipt_invalidAmount` | (txtRemainingAmount fallback) | Geçersiz | Invalid |

---

#### 3.2.3 Klasör Arama Paneli (pnlFindFolder)

| JSON Key | Kaynak | TR | EN |
|----------|--------|----|----|
| `find_selectDrive` | lblSürücüSeç.Text | Sürücü Seç: | Select Drive: |
| `find_enterFolderName` | lblKlasörAdıGir.Text | Klasör Adı Gir: | Enter Folder Name: |
| `find_search` | lblSearchFile.Text | Ara | Search |
| `find_foundFolders` | lblBulunanKlasörler.Text | Bulunan Klasörler: | Found Folders: |
| `find_notFound` | (listBox fallback) | Bulunamadı | Not Found |

---

#### 3.2.4 Arşiv Paneli (flowLayoutPanelArchive)

| JSON Key | Kaynak | TR | EN |
|----------|--------|----|----|
| `archive_title` | lblMainArchiveCaption.Text | ARŞİV İŞLEMLERİ | ARCHIVE OPERATIONS |
| `archive_searchRecord` | btnSearchPhoto.Text | Arşivde Kayıt Ara | Search Archive Record |
| `archive_addFolders` | btnAddFoldersToArchive.Text | Hazırlanan Dosyaları Arşive Ekle | Add Prepared Folders to Archive |
| `archive_backup` | btnMakeSpare.Text | Arşivi Yedekle | Backup Archive |
| `archive_loadBackup` | btnAddSpareToArchive.Text | Yedeği Arşive Yükle | Load Backup to Archive |

---

#### 3.2.5 Arşiv > Fotoğraf Arama (pnlSearchPhoto)

| JSON Key | Kaynak | TR | EN |
|----------|--------|----|----|
| `search_enterName` | lblFullName.Text | Aradığınız kaydın ismini giriniz (ad soyad): | Enter the record name (full name): |
| `search_foundRecords` | lblFound.Text | Bulunan Kayıtlar: | Found Records: |
| `search_representativePhoto` | lblFoundPhoto.Text | Temsili Kayıt Fotoğrafı | Representative Record Photo |
| `search_recordCount` | lblKayıtSayısı.Text | Kayıt Sayısı= | Record Count= |
| `search_parentFolder` | lblSeçilenKaydınBulunduğuÜstKlasör.Text | Seçilen Kaydın Bulunduğu Üst Klasör: | Parent Folder of Selected Record: |
| `search_updateRecord` | lblKaydıGüncelle.Text | Kaydı Güncelle | Update Record |
| `search_deleteRecord` | lblKaydıSil.Text | Kaydı Sil | Delete Record |
| `search_openFolderTitle` | lblKaydınKlasörünüAçmakİçin.Text | Kaydın Klasörünü Açmak İçin: | To Open Record Folder: |
| `search_selectDriveFirst` | lblChooseDriver.Text | Önce Sürücü Seç: | Select Drive First: |
| `search_searchParentFolder` | lblSearchArchive.Text | Üst Klasörü Ara | Search Parent Folder |
| `search_goToRecordFolder` | lblGoRecord.Text | Kayıt Dosyasına | To Record File |
| `search_go` | lblGit.Text | Git | Go |
| `search_dataGridHeaderFullName` | DataGrid "Ad Soyad" sütunu | Ad Soyad: | Full Name: |

---

#### 3.2.6 Arşiv > Klasörleri Arşive Ekle (pnlAddFoldersToArchive)

| JSON Key | Kaynak | TR | EN |
|----------|--------|----|----|
| `addFolder_prepared` | lblHazırlamışolduğunuz.Text | Hazırlamış olduğunuz, | The folder you have prepared, |
| `addFolder_containing` | lblmüşterilerinkayıtdosyalarınıbulunduran.Text | müşterilerin kayıt dosyalarını bulunduran, | containing customer record files, |
| `addFolder_selectParent` | lblÜSTKLASÖRÜNÜZÜSeçiniz.Text | ÜST KLASÖRÜNÜZÜ Seçiniz: | Select your PARENT FOLDER: |
| `addFolder_selectedParent` | lblArşiveEklemekİçinSeçilenÜstKlasör.Text | Arşive Eklemek İçin Seçilen Üst Klasör | Selected Parent Folder for Archive |
| `addFolder_addToArchive` | lblAddFolderToArchive.Text | Arşive Ekle | Add to Archive |
| `addFolder_or` | lblVeya.Text | Veya, | Or, |
| `addFolder_previouslyPrepared` | lblÖncedenArşiveeklemeküzerehazırladığınız.Text | Önceden Arşive eklemek üzere hazırladığınız, | Previously prepared for archive, |
| `addFolder_containingParent` | lblÜSTklasörleribarındıran.Text | ÜST klasörleri barındıran | containing PARENT folders |
| `addFolder_selectGeneralParent` | lblGenelÜSTARŞİVKLASÖRÜNÜZÜSeçiniz.Text | Genel ÜST ARŞİV KLASÖRÜNÜZÜ Seçiniz: | Select your General ARCHIVE PARENT FOLDER: |
| `addFolder_pleaseWait` | (dinamik label değişimi) | Lütfen bekleyiniz.. | Please wait.. |

---

#### 3.2.7 Arşiv > Yedekle (pnlMakeSpare)

| JSON Key | Kaynak | TR | EN |
|----------|--------|----|----|
| `spare_backupArchiveLabel` | lblVeriTabanındakiarşiviyedeklemekiçin.Text | Veri Tabanındaki arşivi yedeklemek için | To backup the archive in database |
| `spare_selectLocation` | lblDosyaKonumuSeçiniz.Text | Dosya Konumu Seçiniz: | Select File Location: |
| `spare_selectedLocation` | lblSeçilenKonum3.Text | Seçilen Konum: | Selected Location: |
| `spare_backupToFile` | lblDbToFolder.Text | Arşivi Dosyaya Yedekle | Backup Archive to File |

---

#### 3.2.8 Arşiv > Yedeği Arşive Yükle (pnlAddSpareToArchive)

| JSON Key | Kaynak | TR | EN |
|----------|--------|----|----|
| `restore_previouslyBacked` | lblDahaöncedenyedeklediğiniz.Text | Daha önceden yedeklediğiniz | Your previously backed up |
| `restore_selectFile` | lblDosyayıSeçiniz.Text | Dosyayı Seçiniz: | Select File: |
| `restore_selectedFile` | lblSeçilenYedekDosyası.Text | Seçilen Yedek Dosyası: | Selected Backup File: |
| `restore_loadToArchive` | lblSpareToArchive.Text | Yedek Dosyayı Arşive Ekle | Load Backup File to Archive |

---

#### 3.2.9 Veritabanı Paneli (pnlDBprocess)

| JSON Key | Kaynak | TR | EN |
|----------|--------|----|----|
| `db_create` | lblVeriTabanınıOluştur.Text | Veri Tabanını Oluştur | Create Database |
| `db_backup` | lblVeriTabanınıYedekle.Text | Veri Tabanını Yedekle | Backup Database |
| `db_restoreFromBackup` | lblYedektenVeriTabanınıOluştur.Text | Yedekten Veri Tabanını Oluştur | Restore Database from Backup |
| `db_delete` | lblVeriTabanınıSil.Text | Veri Tabanını Sil | Delete Database |
| `db_selectedLocation` | lblSeçilenKonum2.Text | Seçilen Konum: | Selected Location: |
| `db_selectedBackup` | lblSeçilenYedek.Text | Seçilen Yedek: | Selected Backup: |
| `db_info_create` | richTextBox2.Text | - Program ilk çalıştırıldığında veri tabanı otomatik olarak oluşturulur.\n- Şayet veri tabanı oluşturulamamışsa veya silinmişse bu işlev sayesinde boş bir veri tabanı oluşturulabilir. | - The database is created automatically when the program first runs.\n- If the database could not be created or was deleted, an empty database can be created using this function. |
| `db_info_backup` | richTextBox1.Text | - Bu işlem, kayıtlarımızın bulunduğu veri tabanını\n <seçilen konumda> \nyedeklemek için kulanılmalıdır. | - This operation should be used to backup the database containing our records\n at <selected location>. |
| `db_info_restore` | richTextBox3.Text (resx) | *(resx'ten çekilecek)* | *(to be translated)* |
| `db_info_delete` | richTextBox4.Text (resx) | *(resx'ten çekilecek)* | *(to be translated)* |

---

#### 3.2.10 Şifre Diyaloğu (PasswordDialog.cs)

| JSON Key | Kaynak | TR | EN |
|----------|--------|----|----|
| `pwd_title` | PasswordDialog default title | Şifre Girişi | Password Entry |
| `pwd_enterPassword` | Label text | Lütfen şifreyi giriniz: | Please enter the password: |
| `pwd_confirm` | Confirm button text | Onayla | Confirm |
| `pwd_cancel` | Cancel button text | İptal | Cancel |
| `pwd_wrong` | Wrong password MessageBox | Yanlış şifre girdiniz. Lütfen tekrar deneyin. | Incorrect password. Please try again. |
| `pwd_dbOperations` | DB panel title | Veri tabanı işlemleri için \nlütfen yönetici şifresini giriniz: | For database operations,\nplease enter the admin password: |

---

#### 3.2.11 Arşiv Açıklamaları (ArchiveExplanations.cs)

| JSON Key | Kaynak | TR (Özet) | EN (Özet) |
|----------|--------|-----------|-----------|
| `archiveExp_searchPhoto` | ArchiveExplanations.SearchPhoto | Fotoğrafını aradığınız kişinin... | Enter the full name of the person... |
| `archiveExp_addFolders` | ArchiveExplanations.AddFoldersToArchive | Bu işlem için önce bir klasör... | For this operation, first create... |
| `archiveExp_makeSpare` | ArchiveExplanations.MakeSpare | Veri tabanındaki tüm kayıtlarınızı... | You can backup all your records... |
| `archiveExp_addSpareToArchive` | ArchiveExplanations.AddSpareToArchive | Bilgisayarınız formatlanmış... | Your computer may have been formatted... |

> **Not:** Bu açıklama metinleri uzundur, JSON dosyasında tam çevirileriyle yer alacaktır.

---

#### 3.2.12 MessageBox Mesajları (Form1.cs içindeki tüm mesajlar)

| JSON Key | Bağlam | TR | EN |
|----------|--------|----|----|
| `msg_error` | MessageBox title | Hata | Error |
| `msg_warning` | MessageBox title | Uyarı | Warning |
| `msg_info` | MessageBox title | Bilgi | Information |
| `msg_success` | MessageBox title | İşlem Başarılı | Operation Successful |
| `msg_missingInfo` | MessageBox title | Eksik Bilgi | Missing Information |
| `msg_notification` | MessageBox title | Bilgilendirme!! | Notification!! |
| `msg_sorry` | MessageBox title (eski demo) | Üzgünüm | Sorry |
| `msg_folderFileCreated` | Save success | Klasör ve dosya başarıyla oluşturuldu. | Folder and file created successfully. |
| `msg_duplicateFolder` | Duplicate save | Daha önce aynı isimli kayıt olduğu için, yeni kaydınız \"{0}\" olarak oluşturuldu. | A record with the same name already existed, your new record was created as \"{0}\". |
| `msg_enterName` | Missing name | Lütfen Ad Soyad girin | Please enter a name |
| `msg_selectSaveLocation` | Missing location | Lütfen kayıt için konum seçiniz! | Please select a save location! |
| `msg_noRecordYet` | No record yet | Henüz bir kayıt işlemi gerçekleşmedi! | No save operation has been performed yet! |
| `msg_errorOccurred` | Generic error | Hata oluştu: {0} | An error occurred: {0} |
| `msg_selectFolderAndDrive` | Missing input | Lütfen klasör adını ve sürücüyü seçin. | Please select folder name and drive. |
| `msg_noAccessPermission` | Access denied | Bu dizine erişme izniniz yok. | You don't have permission to access this directory. |
| `msg_folderNotFound` | Folder not found | Belirtilen klasör bulunamadı! | The specified folder was not found! |
| `msg_noSubFoldersFound` | No subfolders | Belirtilen üst klasörde kaydedilecek alt klasör bulunamadı! | No subfolders to save were found in the specified parent folder! |
| `msg_archiveResult_total` | Archive result | Toplam kayıt sayısı: {0} | Total record count: {0} |
| `msg_archiveResult_success` | Archive result | Başarılı kayıt sayısı: {0} | Successful record count: {0} |
| `msg_archiveResult_duplicate` | Archive result | Tekrar ettiği için veri tabanına eklenMEYEN kayıt sayısı: {0} {1} | Records NOT added due to duplicates: {0} {1} |
| `msg_archiveResult_error` | Archive result | Hata alındığı için veri tabanına ekleNEMEYEN kayıt sayısı: {0} {1} | Records that FAILED to add due to errors: {0} {1} |
| `msg_archiveResult_successNotes` | Archive result header | BAŞARILI KAYITLARDA İLAVE NOTLAR: | ADDITIONAL NOTES ON SUCCESSFUL RECORDS: |
| `msg_archiveResult_noImage` | Archive result | Uygun resmi olmayan kayıt sayısı: {0} {1} | Records without a suitable image: {0} {1} |
| `msg_archiveResult_faultyImage` | Archive result | Resmi bozuk veya işlenemeyen kayıt sayısı: {0} {1} | Records with corrupt or unprocessable images: {0} {1} |
| `msg_dbSavedToFolder` | DB export success | Veritabanındaki veriler başarıyla klasöre kaydedildi! | Database records were successfully saved to folder! |
| `msg_spareResult_total` | Spare result | Toplam kayıt sayısı: {0} | Total record count: {0} |
| `msg_spareResult_success` | Spare result | Başarılı kayıt sayısı: {0} | Successful record count: {0} |
| `msg_spareResult_duplicate` | Spare result | Tekrar eden kayıt sayısı: {0} {1} | Duplicate record count: {0} {1} |
| `msg_spareResult_wrongFormat` | Spare result | İsmi uygun olmayan kayıt sayısı: {0} {1} | Records with incorrect name format: {0} {1} |
| `msg_spareResult_notImage` | Spare result | Resim olmayan kayıt sayısı: {0} {1} | Non-image record count: {0} {1} |
| `msg_spareResult_dbError` | Spare result | Veritabanına kayıt esnasında hata alınan kayıt sayısı: {0} {1} | Records that errored during database insert: {0} {1} |
| `msg_selectNameFromTable` | Record not selected | Lütfen Ad Soyad tablosundan bir kayıt seçin! | Please select a record from the Name table! |
| `msg_folderCannotOpen` | Folder open error | Klasör açılamadı: {0} | Could not open folder: {0} |
| `msg_folderNotFoundPath` | Folder not found (path) | Belirtilen klasör bulunamadı: {0} | The specified folder was not found: {0} |
| `msg_confirmUpdate` | Update confirm | Kaydı güncellemek istediğinize emin misiniz? | Are you sure you want to update this record? |
| `msg_recordUpdated` | Update success | Kayıt başarıyla güncellendi. | Record updated successfully. |
| `msg_updateError` | Update error | Kayıt güncellenirken hata oluştu! {0} | Error updating record! {0} |
| `msg_confirmDelete` | Delete confirm | Kaydı silmek istediğinize emin misiniz? | Are you sure you want to delete this record? |
| `msg_recordDeleted` | Delete success | Kayıt başarıyla silindi. | Record deleted successfully. |
| `msg_deleteError` | Delete error | Kayıt silme işleminde hata oluştu! {0} | Error during record deletion! {0} |
| `msg_dbAlreadyExists` | DB exists | Veri tabanı zaten mevcut | Database already exists |
| `msg_dbCreated` | DB created | Veri tabanı başarıyla oluşturuldu | Database created successfully |
| `msg_dbCreateError` | DB create error | Veri tabanı oluşturulurken bir hata oluştu: {0} | Error creating database: {0} |
| `msg_dbCreateErrorGeneric` | DB create error 2 | Veri tabanı oluşturulurken bir hata oluştu | Error creating database |
| `msg_dbNotCreated` | DB not found | Veri tabanı oluşturulmamış, Lütfen 'Veri Tabanı' işlemi menüsünde, veri tabanı oluşturunuz ve kayıtlarınızı ekleyiniz! | Database not found. Please create a database in the 'Database' operations menu and add your records! |
| `msg_searchError` | Search error | Kayıt ararken hata oluştu! {0} | Error searching records! {0} |
| `msg_confirmDeleteDB` | Delete DB confirm | Veri tabanınızı !!!Geri Getiremeyecek Şekilde!!! silmek istediğinize emin misiniz? | Are you sure you want to delete your database !!!IRREVERSIBLY!!!? |
| `msg_confirmDeleteDBFinal` | Final delete confirm | Veri tabanınız tamamen kaldırılacak, onaylıyor musunuz? | Your database will be completely removed, do you confirm? |
| `msg_dbRemoved` | DB removed | Veri tabanı başarıyla kaldırıldı | Database removed successfully |
| `msg_dbRemoveError` | DB remove error | Veri tabanı kaldırılırken bir hata oluştu: {0} | Error removing database: {0} |
| `msg_dbNotExists` | DB not found | Veri tabanı sistemde mevcut değil | Database does not exist in the system |
| `msg_selectBackupLocation` | Backup location | Lütfen yedekleme dosyasını oluşturacağınız bir konum seçin! | Please select a location to create the backup file! |
| `msg_backupCompleted` | Backup done | Yedek alma işlemi tamamlandı. | Backup operation completed. |
| `msg_backupError` | Backup error | Yedek dosyası oluşturulurken hata meydana geldi: {0} | Error creating backup file: {0} |
| `msg_selectRestoreFile` | Restore select | Lütfen geri yüklemek için bir dosya seçin. | Please select a file to restore. |
| `msg_confirmRestore` | Restore confirm | Seçtiğiniz yedek dosyası yüklenirken mevcut veri tabanınız silinmiş olacak, devam etmek istediğinize emin misiniz? | Your current database will be deleted while loading the backup file, are you sure you want to continue? |
| `msg_restoreCompleted` | Restore done | Veritabanı geri yükleme işlemi tamamlandı. | Database restore operation completed. |
| `msg_restoreError` | Restore error | Veritabanı geri yükleme işleminde bir hata oluştu: {0} | An error occurred during database restore: {0} |

---

#### 3.2.13 Dil Değiştirme UI (Yeni)

| JSON Key | Bağlam | TR | EN |
|----------|--------|----|----|
| `lang_label` | Dil seçimi label | Dil: | Language: |
| `lang_restartMessage` | Yeniden başlatma mesajı | Dil değişikliğinin uygulanması için program yeniden başlatılacaktır. Devam etmek istiyor musunuz? | The application will restart to apply the language change. Do you want to continue? |
| `lang_restartTitle` | Yeniden başlatma title | Dil Değişikliği | Language Change |

---

#### 3.2.14 Dinamik Olarak Değişen Label'lar (SetLoading metodu)

| JSON Key | Bağlam | TR | EN |
|----------|--------|----|----|
| `loading_pleaseWait` | SetLoading addFolder=true | Lütfen bekleyiniz.. | Please wait.. |
| `loading_addToArchive` | SetLoading addFolder=false | Arşive Ekle | Add to Archive |
| `loading_backupToFile` | SetLoading addDbToFolder=false | Arşivi Dosyaya Yedekle | Backup Archive to File |
| `loading_loadBackupToArchive` | SetLoading addSpare=false | Yedek Dosyayı Arşive Ekle | Load Backup File to Archive |

---

## 4. Değiştirilecek Dosyalar

### 4.1 Yeni Oluşturulacak Dosyalar
| Dosya | Açıklama |
|-------|----------|
| `PhotoEmin/Helpers/LanguageManager.cs` | Dil yönetim sınıfı |
| `PhotoEmin/Model/LanguageInfo.cs` | Dil bilgi modeli |
| `PhotoEmin/Languages/tr.json` | Türkçe çeviriler |
| `PhotoEmin/Languages/en.json` | İngilizce çeviriler |

### 4.2 Değiştirilecek Mevcut Dosyalar
| Dosya | Değişiklik |
|-------|------------|
| `PhotoEmin/Form1.cs` | - `ApplyLanguage()` metodu eklenecek (tüm label/button text'lerini JSON'dan yükler)<br>- Form Load'da `LanguageManager.Initialize()` ve `ApplyLanguage()` çağrılacak<br>- Dil dropdown eklenmesi ve event handler<br>- Tüm MessageBox string'leri `LanguageManager.GetString()` ile değiştirilecek<br>- `SetLoading()` içindeki hardcoded string'ler değiştirilecek |
| `PhotoEmin/Form1.Designer.cs` | - ComboBox (cmbLanguage) + Label (lblLanguage) tanımları eklenecek<br>- Ana form'a yerleştirilecek (sol menü panelinde veya üst kısımda) |
| `PhotoEmin/Model/ArchiveExplanations.cs` | - Static const yerine `LanguageManager.GetString()` çağrılarına dönüştürülecek<br>- Veya property olarak değiştirilecek |
| `PhotoEmin/Forms/PasswordDialog.cs` | - Tüm hardcoded string'ler `LanguageManager.GetString()` ile değiştirilecek |
| `PhotoEmin/Helpers/AppConfig.cs` | - Dil ayarı okuma/yazma desteği eklenecek (opsiyonel, ayrı config da olabilir) |
| `PhotoEmin/PhotoEmin.csproj` | - `Languages/*.json` dosyalarının output'a kopyalanması için `<Content>` veya `<None>` item eklenecek |

---

## 5. Uygulama Adımları (Sıralı)

### Adım 1: Altyapı
1. `Languages/` klasörünü oluştur
2. `LanguageInfo.cs` modelini oluştur
3. `LanguageManager.cs` sınıfını oluştur
4. `PhotoEmin.csproj`'a JSON dosyalarının build output'a kopyalanması kuralını ekle

### Adım 2: Dil Dosyaları
5. `tr.json` dosyasını tüm key-value çiftleriyle oluştur
6. `en.json` dosyasını tüm key-value çiftleriyle oluştur

### Adım 3: UI Değişiklikleri
7. `Form1.Designer.cs`'e dil seçim dropdown'u ekle (cmbLanguage + lblLanguage)
8. `Form1.cs`'e `ApplyLanguage()` metodu ekle - tüm UI elemanlarını JSON'dan günceller
9. Form Load event'inde `LanguageManager.Initialize()` + `ApplyLanguage()` çağır
10. Dropdown change event handler: config'e yaz → restart mesajı → `Application.Restart()`

### Adım 4: String Çevirileri
11. `Form1.cs` içindeki tüm MessageBox çağrılarını `LanguageManager.GetString()` ile değiştir
12. `SetLoading()` içindeki hardcoded label text'lerini değiştir
13. `ArchiveExplanations.cs`'i JSON tabanlı yapıya dönüştür
14. `PasswordDialog.cs` içindeki string'leri değiştir
15. DataGrid kolon header'larını dil dosyasından oku

### Adım 5: Config ve Build
16. Dil seçim tercihi saklama mekanizmasını implement et (appsettings.json veya language.config)
17. Test: Türkçe → İngilizce geçişi ve geri dönüşü
18. Test: Yeni dil dosyası ekleme (fr.json oluşturulduğunda dropdown'da çıkması)

---

## 6. Önemli Notlar

1. **ArchiveExplanations.cs** - Bu dosyadaki uzun açıklama metinleri de JSON'a taşınacak. Static const yapısı yerine `LanguageManager.GetString()` kullanılacak.

2. **richTextBox1-4 Metinleri** - DB panelindeki açıklama metinleri de JSON'dan okunacak. richTextBox3 ve richTextBox4'ün metinleri `.resx` dosyasından çekilmektedir; bunlar da JSON'a taşınacak.

3. **Dinamik Metinler** - `SetLoading()` içindeki label text değişimleri (örn: "Lütfen bekleyiniz..", "Arşive Ekle") de JSON key'leri kullanacak.

4. **Format String'ler** - `{0}`, `{1}` gibi placeholder'lar `string.Format()` ile kullanılacak.

5. **Varsayılan Dil** - Eğer config'de dil ayarı yoksa veya belirtilen JSON bulunamazsa, `tr.json` varsayılan olarak yüklenecek.

6. **Yeniden Başlatma** - Dil değişikliği Application.Restart() ile uygulanacak. Bu, tüm form elemanlarının düzgün şekilde güncellenmesini garanti eder.

7. **JSON Encoding** - Dosyalar UTF-8 (BOM'suz) olarak kaydedilecek, Türkçe karakterler düzgün çalışacak.

8. **Bulunamayan Key** - `LanguageManager.GetString("key")` eğer key bulunamazsa, key'in kendisini döndürecek (hata vermeyecek).

---

## 7. Tahmini Etki Alanı

| Kategori | Sayı |
|----------|------|
| Çevirilecek label/button text | ~65 |
| Çevirilecek MessageBox mesajı | ~40 |
| Çevirilecek ArchiveExplanation | 4 (uzun metin) |
| Çevirilecek PasswordDialog metni | 5 |
| Çevirilecek DB info RichTextBox | 4 |
| Çevirilecek dinamik text (SetLoading) | 4 |
| **Toplam benzersiz çeviri key** | **~120+** |
