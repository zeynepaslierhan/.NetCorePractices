<h1 align="center">
  <br>
  <a href="https://github.com/zeynepaslierhan/.NetCoreArchive"><img src="https://github.com/zeynepaslierhan/.NetCorePractices/blob/main/img/Readme/Logo.png" alt="SoftwareDeveloperArchive" width="200"></a>
  <br>
  Blog Sitesi Projesi / .Net Core 5.0
  <br>
</h1>


.Net Core konusunda gelişmek için  Murat Yücedağ'ın .Net Core Proje kampını baz alarak çalıştım. 
Murat Yücedağ'ın projesinde temiz kod kullanımı ve  n katmanlı mimariyle oluşturulması .NET Core konusunda sağlam bir temel atmamı sağladı.

## N Katmanlı Mimari

Bu mimari, projeye eklenen class libraryler ile sağlanır. Class library seçilirken .NetCore projesi yapıyorsanız .Net core library’i seçtiğinizden emin olun.

**Entity Layer**, Projede bulunan tablolar ve bunların içinde bulunun sütunlar yer alır.Buradaki yapılar class olarak tutulur.

**Data Access Layer,** veri erişim katmanıdır.Veritabanındaki  **CRUD(Create-Read-Update-Delete)** operasyonlarını içerir. 

**Business Layer,** validasyon(doğrulama) işlemlerinin yapıldığı katmandır.

**Presentation Layer,** sunum UI işlemleri yapılır. diğer deyişle kullanıcı arayüzüdür.

### Katmanlar Arası Referans Alımı

**Entity Layer:** katmanlardan referans almaz çünkü sadece entity’ler (varlıklar) burada oluşturulur ve bunlar diğer katmanlarda kullanılır.

**Data Acces Layer**: Entity Layer’ı referans alır.Çünkü sadece CRUD işlemlerinden ibarettir ve bunlara dahil olacak entityler için sadece Entity Layer katmanını referans alır.

**Business Layer:** Data Acces ve Entity Layer’ı referans alır. 

**Presentation Layer:** Entity, Data Acces, Business Layer. Validasyon kontrolleri, Crud işlemleri ve gereken parametrelerde class’larla alınacağı için entity layer referans alınır.

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

[**.Net Core ile Blog Sitesi Oluşturma / PART 6**](https://www.youtube.com/watch?v=cQgKav7Y4QU) *içeriği*:

1. UI katmanında: UserLayout'da kullanılan PartialView düzenlendi.

2. UI katmanı işlemleri, RegisterController eklendi.

3. Business Layer işlemleri : IWriterService ve WriterManager oluşturuldu. WriterManager için gerekli yerler düzenlendi. (İlerleyen zamanlarda Generic işlemler bussines layer için de yapılacak)

4. UI katmanı işlemleri, RegisterController düzenlendi. 
5. UI katmanı işlemleri, Register View oluşturulup düzenlendi.(Noktalı virgül koymadığımdan ilk başta oluşturmamış)

6. Sweet Alert kullanımı için web sitesinden alarm bakıldı. Sonra ilgili kütüphane eklenip Register view düzenlendi.

7. Business Layer işlemleri , Fluent Validation Nuget paketleri eklendi.

8. Business Layer işlemleri , Validation Rules klasörü işlemleri başladı. WriterValidator oluşturulup Register sayfası için istediğimiz kurallar belirlendi.

9. UI Layer işlemleri , Fluent Validation Nuget paketleri eklendi.

10. UI Layer işlemleri , RegisterController'a WriterValidator eklenip gerekli işlemler yapıldı. (Burada yanlış kütüphane eklenip eklenmediğinden emin olmak lazım)

11. UI Layer işlemleri, Register View'da düzenlemeler yapıldı. (Şifreyi iki defa kontrol etme kısmını ilerde göstereceğim. İsterseniz githubdan projenin ilerlemiş aşamalarına bakabilirsiniz.)

[**.Net Core ile Blog Sitesi Oluşturma / PART 7**](https://www.youtube.com/watch?v=uCEO-MtshnU) *içeriği*:

1. UI katmanında: Login Controller Oluşturulup Login View sayfası eklendi. İstenilen Login şablonu View'a eklenip gerekli düzenlemeler yapıldı. ( Bu kısmın işlemleri ilerleyen zamanlarda yapılacak)

2. UI Katmanında: Layout içerisindeki Partial 2 düzenlendi.

3. Entity katmanında: Blog ve Writer arasındaki ilişki kuruldu. Migration dosyasına değişiklik kaydedilip veritabanına yansıtıldı. (Hatayı almamak adına migration içerisindeki nullable true yapıldı.)

4. Bussines Katmanında: IBlogService interface'i içerisine yeni method tanımlandı.  Dolayısıyla BlogManager düzenlendi.

5. UI Katmanında: ViewComponents içerisine Blog klasörü eklenip WriterLastBlog adında yeni class oluşturuldu. Bu class ViewComponent olarak kullanılacağı için ViewComponent'den miras alınıp içeriği düzenlendi.

6. Veritabanına örnek veriler girildi.

7. UI Katmanında: View/Shared/Component içine WriterLastBlog adında yeni klasör oluşturuldu. İçine view eklenip ismi default olarak değiştirildi. İstenilen kısım BlogReadAll view'ı içerisinden alınıp düzenlendi. 

8. UI Katmanında: Çoğunlukla View içeriklerine eklenen klasörü ViewImports içerisine eklendi. İleride sürekli eklemekle tekrardan uğraşmamak adına pratik bir çözümdür. Sonrasında kullanılan view'lardan silindi.

9. UI katmanında: Burada oluşturulan viewcomponent'in id değer alması için işlemler denendi fakat istenildiği gibi çalışmadı. Murat Yücedağın ilerleyen videoalarda bu component yerine yaptığı component onun yerine eklenmeye başladı.

İstenildiği gibi çalışmadığını projenin devamında fark ettiğim için BlogLastThreePosts Componentinin yapılışını sonradan çektim. Videodaki bütünlük bozulmaması adına sonuna ekledim. 

10. UI Katmanında: ViewComponents/Blog içerisine BlogLastThreePost class'ı eklenip içeriği düzenlendi.

11. Bussines katmanında: IblogService ve BlogManager içerisine istenilen method eklenip düzenlendi.

12. UI Katmanında: Component içerisine BlogLastThreePosts adında yeni klasör eklenip default adında view eklendi.

13. UI Katmanında: BlogReadAll View'ı içerisi düzenlendi. 

14. UI Katmanında: WriterLastBlog View'ında kullandığımız cshtml kodları BlogLastThreePosts 'a aktarılıp düzenlendi.

[**.Net Core ile Blog Sitesi Oluşturma / PART 8**](https://www.youtube.com/watch?v=wMxm9SyOpEA) *içeriği*:

1. Entity Katmanında: NewsLetter class'ı oluşturulup içeriği düzenlendi.

2. DataAcces Katmanında: Context içeriği düzenlendi. Migration oluşturulup veritabanına yansıtıldı.

3. UI Katmanında:  NewsLetter adında yeni Controllers oluşturuldu. PartialView oluşturulmak istendiği için gerekli düzenlemeler yapıldı.

4. DataAcces Katmanında: INewsLetterDal ile EFNewsLetterRepository oluşturuldu.

5. Bussines Katmanında: INewsLetterService ile NewsLetterManager oluşturulup düzenlendi.

6. UI Katmanında: NewsLetterController düzenlendi. SubscribeMail View'ı oluşturuldu. BlogReadAll içerisinden istenilen kısımlar alınıp SubscribeMail View'a eklendi.

7. Alınan hatanın giderilmesi için veritabanında önceden eklenmiş olan veriler değiştirip düzenlendi.

8. Oynatma Serisinin 7. PARTINDA:  BlogReadAll sayfasındaki yazara ait son postların istenildiği gibi çalışmadığını görünce düzenledim. Bu kısmı 7. partta yaptığım için o videonun sonuna ekledim. 

[**.Net Core ile Blog Sitesi Oluşturma / PART 9**](https://www.youtube.com/watch?v=OY0v4V537hc) *içeriği*:

1. Business Katmanında: Generic hale getirmek için işlemler başladı. IGenericService oluşturulup diğer interface'ler için uygulandı.

2. UI Katmanında: Bussines Katmanında yapılan değişikliklerin nerelere yansıyabileceği düşünüldü.

3. Business Katmanında: Interface'lerde yapılan değişiklik manager sınıflarına yansıdığı için düzenlemeler yapıldı.  (Bu tarz düzenlemeler yaparken github gibi araçlar kullanıyorsanız hata almamanız kolaylaşır. Instagram hesabımdan Git,Github,Gitlab içerikleri yayınlayacağım takipte kalın.. :) )

4. UI Katmanında: ErrorPageControllers eklenip Views eklendi. Kullanılacak şablon kendi views içeriğimize eklendi. 

5. UI Katmanında: ErrorPage için startup içerisi düzenlendi.

6. UI Katmanında : AboutController eklenip View eklendi.

7. Business Katmanında: IAboutService ve AboutManager oluşturuldu.

8. UI Katmanında: AboutController düzenlenip içerisine partail View eklenip cshtml düzenlendi. About sayfasının içeriği düzenlendi.

9. UI Katmanında: Site Genelinde Düzenlemeler Başladı. ISS çalıştırıldığında ilk gelecek ekran blog sitesi olarak ayarlandı. Layout'un yönlendirdiği sayfalar düzenlenip istenmeyen kısımlar kaldırıldı.

10.  UI Katmanında: Layout'un alt kısmı yani partial3 düzenlemeleri bağladı. Buradaki kısımlar için önceden oluşturulmuş viewcomponentler kullanıldı.

[**.Net Core ile Blog Sitesi Oluşturma / PART 10**](https://www.youtube.com/watch?v=lrMMZUwg32k&list=PLjMBQHLzNCzaCU6pl57ik1tHxBB0_XifG&index=11&t=624s&ab_channel=SoftwareDeveloperArchive) *içeriği*:

1. UI Katmanında: Login işlemi başlangıcı yapıldı. Startup dosyasında düzenlemeler yapıldı. (Yapıldıktan sonra sayfada göründüğü gibi bir hata oluyor, diğer işlemler yapıldığında geçecek.)

2. UI Katmanında: LoginController düzenlemeleri yapıldı.

3. UI Katmanında: WriterController oluşturuldu. Login işlemi gerçekleşince gidilmesi gereken sayfanın dosyaları hazırlandı.(LoginController içerisindeki 2. fonksiyonun dönüş değeri olmadığından hata veriyordu. o Hata düzenleni Writer/Index oluşturuldu.)

4. UI Katmanında: LoginController düzenlemeleri yapıldı.

5. UI Katmanında: Login/Index.cshtml dosyası düzenlendi. Gerekli input bilgilerin sorgulanabilmesi için Writer entity'sine uygun isimlendirme yapıldı.

6. UI Katmanında: LoginController düzenlemeleri yapılıp kontrol edildi.

7. Login işlemi için Writer bilgisi eklenip proje kontrol edildi. ( Şuan login işlemi yapmaan hiçbir sayfaya yönlendirilmiyor, Giriş yap gibi login gerekmemesi gereken kısımlar ilerleyen zamanda düzenlenecek)

8. UI Katmanında: Writer/Index.cshtml düzenlendi. Yazar paneli için kullanılacak tema dosyasının içeriği kendi projemize uyarlandı. WriterLayout oluşturulup gerekli düzenlemeler yapıldı.(Bu aşamada Writer sayfasının kontrolü için sürekli login işlemi yapmamak adına WriterController'a [AllowAnnonymous] özelliği verildi.)


[**.Net Core ile Blog Sitesi Oluşturma / PART 11**](https://www.youtube.com/watch?v=N8ZChC1COdU&list=PLjMBQHLzNCzaCU6pl57ik1tHxBB0_XifG&index=11&ab_channel=SoftwareDeveloperArchive) *içeriği*:

1. UI Katmanında : WriterLayout' da düzenlendi. 

2. UI Katmanında: WriterLayout partialView'lara ayrılmaya başladı. Bunun için WriterController kullanıldı.

3. UI Kamtanında: WriterLayout için ikinci partialView oluşturuldu. Bunun için WriterController kullanıldı.

4. UI Katmanında: ViewComponents klasörü düzenlendi.  İlgili klasör yolunun sıkıntı yaratabileceği yerler kontrol edildi. (Kullanılmayan kodlar, klasörler, dosyalar sonrasında silinecek)

5. UI Katmanında: WriterLayout içerisine ViewComponentler oluşturulmaya başlandı. Yazarın mesajlarını gördüğü kısım için WriterMessageNotification class'ı oluşturulup WriterLayout'a eklendi.

6. UI Katmanında: WriterLayout içerisine 2. ViewComponent oluşturuldu. Yazarın bildirimlerini gördüğü kısım için WriterNotification class'ı oluşturulup WriterLayout'a eklendi.

7.  UI Katmanında: Yazarın kendi bloglarını listelediği ve listelendiği yerden yönetildiği sayfa için taslak hazırlığı başlandı. WriterController'a BlogListByWriter eklenip View oluşturuldu.

8. Veritabanına veri girişi yapıldı.

9. DataAccess Katmanında: EFBlogRepository içerisine yazar bilgilerine göre kategori bilgisi dahil  blog bilgilerini alan fonksiyon eklendi.

10. Business Katmanında : DataAcces katmanında oluşturulan fonksiyon için IBlogService ve BlogManager güncellendi. 

11. DataAcces Katmanında: Oluşturulan yeni fonskiyon IBlogDal'a da eklendi.

12. UI Katmanında: WriterController içerisine BlogListByWriter sayfası için oluşturulan fonksiyon eklendi.(şimdilik Veritabanında kayıtlı olan Writer için default olarak 7 id'li yazar için sıralama yapıyor.)

13. UI Katmanında: BlogListByWriter View düzenlendi.


[**.Net Core ile Blog Sitesi Oluşturma / PART 12**](https://www.youtube.com/watch?v=FNFHajNJ1MA&list=PLjMBQHLzNCzaCU6pl57ik1tHxBB0_XifG&index=12&ab_channel=SoftwareDeveloperArchive) *içeriği*:

* Yeni Blog Oluşturma 

1.  UI Katmanında: WriterController içerisine Blog Crud işlemleri için gerekli fonksiyonlar eklenmeye başladı. İlk olarak yeni blog oluşturulmak için BlogAdd action'ı oluştulup View eklendi.

2. UI Katmanında: BlogAdd View'ı düzenlendi.

3. Bussines Katmanında: Yeni blog oluştururken dikkat edilmesi gereken kurallar BlogValidator içerisinde tanımlandı.

4. UI Katmanında: Oluşturulan BlogValidator WriterController içerisindeki BlogAdd action'ına eklendi. 

5. UI Katmanında: BlogAdd  View içerisine Validation mesajları eklendi.

* Blog Silme işlemi

1. UI Katmanında: WriterController içerisine DeleteBlog fonksiyonu eklenip BlogListByWriter View'ı güncellendi.

* Blog Güncelleme

1. UI Katmanında: WriterController içerisine BlogEdit fonksiyonu eklenip View oluşturuldu.

* Blog Statüsünü Değiştirme

1. UI Katmanında: WriterController içerisine aynı DeleteBlog mantığında çalışan bir fonksiyon eklenip BlogListByWriter güncellendi.


[**.Net Core ile Blog Sitesi Oluşturma / PART 13**](https://www.youtube.com/watch?v=y8Tlqkaxvhg&list=PLjMBQHLzNCzaCU6pl57ik1tHxBB0_XifG&index=13&ab_channel=SoftwareDeveloperArchive) *içeriği*:

1. UI katmanında: Writerlayout düzenlendi.

2. UI katmanında: Yazar paneline giriş yapan kişinin bilgileri alındı. Bunun için WriterController ve Index View düzenlendi.

3. Business katmanında: yazar paneline giriş yapan kişinin diğer bilgilerine ulaşmak için dataacces katmanında olan parametreli GetListAll methodu business katmanına eklendi.

4. UI Katmanında: WriterController içerisi düzenlenip giriş yapan kişinin mail adresi dışındaki verilere ulaşıldı. Index sayfasına yansıtıldı. 

(Business katmanında yapılan değişikliklerden sonra ilgili kütüphane eklenmediği için hata alındı. İlgili kütüphane eklendiğinde hata çözüldü.)

5. UI katmanında: WriterController içerisindeki methodlara, giriş yapan kişinin hangi verileri lazımsa onlar eklendi.

6. UI katmanında: Yazar panelindeki bloglistbywriter, blogadd ve blogedit sayfalarının önyüzü düzenlendi. (Writer teması kullanıldı.)

7. UI Katmanında: BlogListbyWriter sayfasındaki güncelle butonundaki hata düzenlendi.

8. UI Katmanında: Blogadd ve Blogedit sayfalarına CK editör eklendi.


[**.Net Core ile Blog Sitesi Oluşturma / PART 14**](https://www.youtube.com/watch?v=sj5fI6eWdaM&list=PLjMBQHLzNCzaCU6pl57ik1tHxBB0_XifG&index=14&ab_channel=SoftwareDeveloperArchive) *içeriği*:

1. Projedeki genel eksiklikler.

2. UI katmanında: Ck Editör ile yazılan yazıların düzgün yansıtılması için BlogReadAll ve Blog/Index içerisi düzenlendi.

3.  UI katmanında: CommentListByBlog ViewComponent'i düzenlendi. Blog yazısı için ilgili bir yorum yoksa "İlk Yorumu Sen Yaz " yazısı eklendi.

4. UI Katmanında: LoginController düzenlendi. LogOut/SignOut eklendi. bunun için WriterLayout düzenlendi.

5. UI katmanında: WriterLayout içerisinde kullanılan partialView'lar içerisine ViewComponent eklendi. Profil bilgileri layout içerisinde yansıtıldı.

6. UI Katmanında: WriterController Düzenlendi. Yazar bilgilerinin güncellenme işlemi Blog yazısını güncellemeye benzediği için taslak olarak BlogEdit kodları kullanıldı. Yazarın email adresi değiştiğinde güncelliyor fakat Writer/Index sayfasında artık giriş yapılan kişinin email adresi sistemde olmadığından boş sayfa gönderiyor. Bunu ilerki videolarda düzelteceğim.

***diğer kısımları gelecek...***

<img src="https://github.com/zeynepaslierhan/.NetCorePractices/blob/main/img/Readme/Kaynak%C3%A7a.gif" align="right" height="150">


## Kaynakça :card_file_box:

1. [Murat Yücedağ Proje Kampı](https://www.youtube.com/playlist?list=PLKnjBHu2xXNNkinaVhPqPZG0ubaLN63ci)
2. [Samet Akça ve Rümeysa Çağlar'ın projesi](https://github.com/smtdeveloper/BlogProjeKampi)
3. [Atilla Akalay'ın projesi](https://github.com/atillakalay/DotNetCoreCamp)
