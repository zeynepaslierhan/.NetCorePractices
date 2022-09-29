# .NET Core 5.0 Blog Sitesi

.Net Core konusunda gelişmek için  Murat Yücedağ'ın .Net Core Proje kampını baz alarak çalıştım. 
Murat Yücedağ'ın projesinde temiz kod kullanımı ve  n katmanlı mimariyle oluşturulması .NET Core konusunda sağlam bir temel atmamı sağladı.

Murat Yücedağ  .Net Core Proje Kampı: https://www.youtube.com/playlist?list=PLKnjBHu2xXNNkinaVhPqPZG0ubaLN63ci

---
## Youtube Kanalından İzleyebilirsiniz

Bu çalışmamı aşama aşama [Software Developer Archive](https://www.youtube.com/channel/UCjyA7k3irGFgjYkuH-QVhfw) youtube kanalıma ekledim. İlerleyen zamanlarda diğer partları yayınlayacağım.

İzlemek için: [.Net Core Practices](https://www.youtube.com/playlist?list=PLjMBQHLzNCzaCU6pl57ik1tHxBB0_XifG)

<img src="https://github.com/zeynepaslierhan/.NetCorePractices/blob/main/img/.Net%20Core%20Youtube%20k%C3%BC%C3%A7%C3%BCk%20resim.jpg" width="300" alt=".NetCoreWebApp Practices"/>

[**.Net Core ile Blog Sitesi Oluşturma / PART 1**](https://www.youtube.com/watch?v=6wiOt8ZcPNY&list=PLjMBQHLzNCzaCU6pl57ik1tHxBB0_XifG&index=1) *içeriği*:

1. Katmanlar oluşturuldu

2. Entity Layer işlemleri başladı: Concrete klasöründe class'lar oluşturuldu.

3. DataAcces Layer işlemleri başları: Nuget Paketleri eklendi.  Abstract, Concrete ve Repositories klasörleri oluşturuldu. Concrete içerisinde Context sınıfı oluşturuldu. Konfigürasyon işlemleri yapılıp DbSet ile tüm entity'lerin işlemleri yapıldı. 

4. UI katmanında (Projenin ismi olan katman) işlemler başladı: Nuget Paketler eklendi

5. Migrations ve veritabanı işlemleri başladı.

[**.Net Core ile Blog Sitesi Oluşturma / PART 2**](https://www.youtube.com/watch?v=Y7pg4vaoNdY&list=PLjMBQHLzNCzaCU6pl57ik1tHxBB0_XifG&index=2) *içeriği*:

1. Data Acces Layerda: Blog ve Category arasında ilişki kuruldu, migration işlemlerinden sonra veritabanına yansıtıldı.

2. Data Acces Layerda: Blog ve Comment arasında ilişki kuruldu, migration işlemlerinden sonra veritabanına yansıtıldı.

3. Data Acces Layerda: Abstract klasöründe IGenericDal interface'i oluşturuldu. GenericRepository, Repositories klasöründe IGenericDal'dan kalıtım alarak oluşturuldu. (Bunlar ilerleyen zamanlarda kalıtım alınması için kullanılacak.)

4. Data Acces Layerda: Abstract klasöründe Her Entity için IGenericDal'dan miras alınan interface'ler oluşturuldu.

5. Data Acces Layerda: Entity Framework klasörü oluşturuldu. GenericRepository'den kalıtım alınarak her entity için EF repository classları oluşturuldu. (bu klasörün içerisindekiler Repositories'de de oluşturulabilirler.)

6. Busines Layer işlemleri başladı: Abstract, Concrete ve ValidationRules klasörleri oluşturuldu. Abstract klasöründe ICategoryService interface'i oluşturuldu. Sonra Concrete klasöründe ICategoryService'dan miras alınarak CategoryManager oluşturuldu.

7. UI katmanında (Projenin ismi olan katman): Controller işlemleri başladı. CategoryController oluşturulup ona ait view eklendi. (buradaki amaç web üzerinden geçici bir süreliğine görüntü elde etmek)

8. Veritabanında Categories tablosuna örnek veriler eklendi.

[**.Net Core ile Blog Sitesi Oluşturma / PART 3**](https://www.youtube.com/watch?v=J1rb2JNKTYU&list=PLjMBQHLzNCzaCU6pl57ik1tHxBB0_XifG&index=3) *içeriği*:

1. Category view içersinde görünür bir sonuç elde etmek için tablo bilgilerine erişim sağlanılıyor. (ilerde bu kısmı kullanmayacağız amaç denemek)
2. UI katmanında (Projenin ismi olan katman): Tema işlemleri başladı. UserLayout oluşturuldu.Hazır alınan temanın klasör uzantıları düzenlendi. Kullanacağımız layout partialview bölümlerine ayrıldı. 
3. Business Layerda: IBlogService oluşturuldu. IBlogService'den miras alınarak BlogManager oluşturuldu.
4. UI katmanında (Projenin ismi olan katman): BlogController oluşturuldu. Blog View oluşturulup düzenlendi.
5. Veritabanına örnek blog verileri eklendi.
6. Busines Layerda: Blog yazılarına ait Kategorilerin isimlerini görüntülemek için IBlogServide'e  yeni fonksiyon eklendi. Dolayısıyla BlogManager da düzenlendi.
7. UI katmanında (Projenin ismi olan katman): BlogControllerda istenilen veriyi almak için yeni oluşturulan fonksiyondan alınan veriler kullanıldı.

***diğer kısımları gelecek...***

## Kaynakça

1. [Murat Yücedağ Proje Kampı](https://www.youtube.com/playlist?list=PLKnjBHu2xXNNkinaVhPqPZG0ubaLN63ci)
