﻿namespace PhotoEmin.Model
{
    public static class ArchiveExplanations
    {
        public const string SearchPhoto = "-Fotoğrafını aradığınız kişinin Ad Soyad bilgisini giriniz.\n-Çıkan sonuçlardan uygun olanı tıklayınız.\n>>Kayda ait olan foto ve bulunduğu Üst klasör ismi görünecektir.\n-Eğer ilgili kaydın bulunduğu bellek takılı ise, sürücüyü seçip \"Klasöre Git\" diyerek kayda ait olan klasörü açabilirsiniz.";

        public const string AddFoldersToArchive = "-Bu işlem için önce bir klasör oluşturup içine, arşivlemek istediğiniz kayıtlara ait alt klasörleri kopyalamanız gerekmektedir.\n-Bu alt klasörler, kaydını yaptığınız kişilerin Ad Soyad bilgisi ile isimlendirilmelidir.\n-Arşivleme işleminden sonra \"Arşivde Fotoğraf Ara\" özelliğini etkili olarak kullanabilmeniz amacıyla, herhangi bir alt klasörü(kişiye ait olan kayıt klasörü) arattığınızda, bu kişinin temsili bir resmini de görmek ilgili kaydı hatırlamanıza yardımcı olacaktır. Dolayısıyla bu kişinin seçtiğiniz herhangi bir resmini, mümkün mertebe düşük bir çözünürlükte ayarlayıp, \"a.jpg\" olacak şekilde isimlendirmelisiniz.\n** Kullanım için; \"Üst Klasörü seç\" butonu ile arşivlemek istediğiniz klasörü seçtikten sonra, \"Arşive Ekle\" butonuna basınız.";

        public const string AddSingleToArchive = "-Programımız üzerinden makbuz kesme fonksiyonunu kullanıp, kişiye ait bir klasör oluşturmadıysanız, fotoğraflarını çektiğiniz kişinin \"Ad Soyad\" bilgisi ile bir klasör oluşturunuz.\n-Sonra ilgili fotoğrafları bu klasöre koyup, içlerinden birinin mümkün mertebe düşük çözünürlüklü ve \"a.jpg\" ismiyle bir kopyasını yapınız.\n** Kullanım için; \"Klasör Seç\" butonu ile ilgili kişinin klasörünü seçip, \"Arşive Ekle\" butonuna basınız.";

        public const string MakeSpare = "-Veri tabanındaki tüm kayıtlarınızı bu özellik sayesinde yedekleyebilirsiniz.\n** Kullanım için; Yedeği oluşturmak istediğiniz konumu \"Konum Seç\" butonu ile seçiniz.\n-Konumu seçtikten sonra \"Yedekle\" butonu ile yedekleme işlemini başlatabilirsiniz.\n-Bu işlemin süresi, veri tabanınızın kayıt sayısına göre değişkenlik gösterir.\n\n";

        public const string AddSpareToArchive = "-Bilgisayarınız formatlanmış veya başka nedenlerle veri tabanınız silinmiş olabilir.\n-Bu özellik sayesinde daha önce yedeklediğiniz bir kaydınızı veri tabanınıza aktarabilirsiniz.\n** Kullanım için; \"Yedek Klasörünü Seç\" butonu ile yedeğini almış olduğunuz klasörü seçtikten sonra \"Arşive Ekle\" butonuna basınız.\n-Bu işlemin süresi, yedek dosyanızın kayıt sayısına göre değişkenlik gösterir.\nNot: Bu işlemi aynı yedek dosyasını kullanarak bir kaç kez(yapıp yapmadığınızdan emin olmadığınız durumlarda) tekrar etseniz bile kayıtlarınız arşivde bir kez oluşturulmuş olacaktır.";
    }
}
