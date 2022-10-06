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

[**.Net Core ile Blog Sitesi Oluşturma / PART 4**](https://www.youtube.com/watch?v=ngBsgrw2vQA) *içeriği*:

1. UI katmanında (Projenin ismi olan katman): BlogController içerisine BlogReadAll action'ı eklendi. 
2. Busines Layerda: View oluşturulmadan önce BlogId değerlerine göre blog bilgilerini almak için IGenericDal'a yeni fonksiyon girildi. Dolayısıyla GenericRepository düzenlendi.
3. Busines Layerda: BlogManager'a  GetBlogById fonksiyonu eklendi. (IGenericDal'da oluşturulan fonksiyona IBlogDal'ın miras alması sebebiyle erişildi.)
4.  UI katmanında (Projenin ismi olan katman): BlogControllerda BlogReadAll action'ı düzenlenip view oluşturuldu. 
5. UI katmanında (Projenin ismi olan katman): BlogReadAll View2ı için tema seçilip içeriği düzenlendi. İlgili id'ye göre blog yazısını gösterecek şekilde ayarlandı.
6. UI katmanında (Projenin ismi olan katman): CommentController oluşturuldu. Comment kısmı partial viewlar ile düzenlendi.(2 parçaya ayrıldı)
7. UI katmanında (Projenin ismi olan katman): BlogReadAll'da comment kısmının çıkmasını istediğimiz kısımlar ayarlandı.

[**.Net Core ile Blog Sitesi Oluşturma / PART 5**](https://www.youtube.com/watch?v=XfMq90N7OD0) *içeriği*:

1. BusinessLayerda: ICommentService oluşturuldu. ICommentService'dan kalıtım alınarak CommentManager oluşturuldu.

2. BusinessLayerda: CommentManager içerisi düzenleniyor. 

3.  UI katmanında (Projenin ismi olan katman): CommentController içerisinde CommentManager dan nesne türetilip gerekli işlemler yapıldı. (Buranın içerisinde önceden eklediğimiz PartialView'lar duruyor fakat bunları viewcomponent'e çevireceğiz.)

4. Veritabanında örnek yorum verileri girilip View Component çalışmaları için gerekli olmayan tüm klasörler kapatıldı.

5. UI Layer'da: ViewComponent klasörü oluşturuldu. İçerisine CommentsList adında class oluşturuldu.

6. UI Layer'da: CommentsList  adında oluşturulan class ViewComponent'den miras alarak içeriği oluşturuldu.

7. UI Layerda: View/Shared klasörü içerisine CommentsList adında klasör oluşturuldu. içerisine Razor View eklendi. İsmi "default olarak değiştirildi"

8. UI Layerda: Blog/BlogReadAll.cshtml içerisindeki CommentListByBlog partial view'ı yerine yeni oluşturduğumuz CommentsList View Component'i eklendi

9. UI Layerda: ViewComponents içerisine Comment adında yeni bir klasör oluşturuldu. İçerisine CommentListByBlog class'ı eklenip ViewComponent'den miras alındı.

10. UI Layerda:  CommentListByBlog class'ı içerisi düzenleniyor AMA ekstradan minik düzenlemeler daha yapmak gerektiğinden yorum satırına alındı.

11. UI Layerda: View/Shared klasörü içerisine Components adında klasör oluşturuldu. CommentList de bu klasör içerisine eklendi. Sonra CommentListByBlog adında yeni klasör açılıp içerisine view eklendi.

12. UI Layerda: CommentListByBlog PartialView içerisindeki kodları CommentListByBlog View Compponent'ine eklendi. (Kullanmadığımız kodları ilerleyen zamanlarda düzenleyeceğiz.) Ve içeriği düzenlendi.

13. UI Layerda: Blog id'lerine göre yorumların gelmesi için ilgili controller veview içeriği düzenlendi

14. UI Layerda:  Category kısmı için de View Component oluşturulmaya başlandı. Comment için yapılan işlemlerin aynısı yapıldı.

***diğer kısımları gelecek...***

## Kaynakça

1. [Murat Yücedağ Proje Kampı](https://www.youtube.com/playlist?list=PLKnjBHu2xXNNkinaVhPqPZG0ubaLN63ci)
