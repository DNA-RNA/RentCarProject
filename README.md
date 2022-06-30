# ReCap Project --- Araç Kiralama Sistemi

  
  ##  <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/thumbtack.svg" width="30" height="30"> About The Project -- Proje Hakkında

>### Bu repo ***[C# Yazılım Geliştirici Yetiştirme Kampı](https://www.kodlama.io/courses/)*** 'nda yapılan çalışmalara paralel geliştirilmiştir.

##  <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/thumbtack.svg" width="30" height="30">  Getting Started

Araç kiralanırken yapılacak işlemlerin (araç, müşteri, sipariş ekleme, silme güncelleme) N-katmanlı mimarisi ile oluşturularak ADO.Net ve EntityFramework kullanılarak veritabanı bağlantısı sağlanarak CRUD işlemlerinin yapıldığı örnek bir web projesi.

## <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/book.svg" width="30" height="30"> Prerequisites --- Gerekli Kütüphaneler
 [![.NET](https://img.shields.io/badge/--512BD4?logo=.net&logoColor=ffffff)](https://dotnet.microsoft.com/)  EntityFramework
 
 
  [![.NET](https://img.shields.io/badge/--512BD4?logo=.net&logoColor=ffffff)](https://dotnet.microsoft.com/)  Standart Library 
  
  Autofac, Autofac dependency injection
 FluentValidation
 
 ## <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/database.svg" width="30" height="30"> Database --- Veritabanı Tabloları
 Sistem için gerekli tablolar;
 -  **Cars**: Arabaların bilgilerini tutar.
 - **Colors**: Arabaların renk bilgilerini tutar.
 - **Brands**: Arabaların marka bilgilerini tutar.
 - **Users**: Sistemi kullanacak kişilerin bilgilerini tutar.
 - **Customers**: Kiralayacak kişilerin bilgilerini tutar.
 
 Bu projede veritabanı Visual Studio 2022 için View/ SQL Server Object Explorer yoluyla SQL server içindeki localdb tarafında oluşturulmuştur.
Tablonun kodlarına ulaşmak için --> [Db.Sql](https://github.com/DNA-RNA/RentCarProject/blob/master/db.sql)
 
 
 ![database](https://user-images.githubusercontent.com/77885953/176639156-4f6137e2-b9cb-4269-a95b-71438c100566.png)
 
 ## <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/layer-group.svg" width="30" height="30"> Layers --- Katmanlar
![layers](https://user-images.githubusercontent.com/77885953/176639496-5f17d957-0097-45ee-b248-69c4c061f124.jpg)

Backend katmanı;**Entities**, **DataAccess**, **Business**, **Core**, **WebAPI**, **WepfUI** katmanlarından oluşur.

### **Entities Katmanı** 
Bu katmanda veritabanında oluşturduğumuz tablolara karşılık gelen classları oluşturuyoruz. Bu sınıflar somut oldukları için **Concrete** klasörü altında oluşturduk. Yazılım geliştirme prensiplerine göre açıkta class kalmaması için soyut bir IEntity.cs interface oluşturup bu classlara implement(uyguluyoruz) ediyoruz.

![entities-layer](https://user-images.githubusercontent.com/77885953/176646475-1ee51b03-eb06-42ff-a418-df4d31a636c5.png)

***

### **DataAccess Katmanı** 
Bu katmanda Entity katmanındaki nesnelerin CRUD(Create Read Update Delete) işlemlerini yapıyoruz. **Abstract** klasöründe soyut nesnelerimiz,  **Concrete** klasöründe ise somut nesnelerimiz bulunmaktadır.
Veritabanı ile Entity arasındaki bağlantıyı sağlamak için **ORM(Object Relational Mapper)** programlama tekniğini kullanırız. Bunu uygulamak için geliştirilmiş birçok toollar var(NHibernate,Inmemory,MyBatis vb.) Bu projede **EntityFramework** kullanıldı. Belki sonradan başka teknoloji kullanma kararı alınırsa diye sisteme doğrudan eklemiyoruz. Böylece **SOLID'in O (Open closed prenciple)** prensibine uygun hale getiriyoruz. Yani yeni özellik eklense bile mevcut kodlar etkilenmemeli.
****
![database-layer](https://user-images.githubusercontent.com/77885953/176658984-0ad16d8d-1c18-43a7-86ad-7e6165ed0fda.png)

***
### **Business Katmanı** 
 **Business Katmanı**'nı sunum katmanından gelen bilgileri gerekli koşullara göre işlemek veya denetlemek  ve **DataAccess** katmanındaki işlemleri yönetmek için oluşturulmuştur. Abstract, Concrete, Constants, DependencyResolvers ve ValidationRules olmak üzere dört adet klasör bulunmaktadır. **Abstract** klasörü soyut nesneleri, **Concrete** klasörü somut nesneleri tutmak için oluşturulmuştur. 
 **ValidationRules** klasörlerinde validation işlemlerinin gerçekleştiği classlar mevcuttur.
  **Dependency Business** klasörüne ise Ioc altyapısını kullanacağımız NuGetleri eklenmiştir. AutoFac kullanılarak **WebAPI**'de startup.cs 'deki servisleri ekleme işlemleri gerçekleştirilmiştir.
  ***
  ![business](https://user-images.githubusercontent.com/77885953/176678261-0ab5b9f1-617d-4d95-9922-a9e3b72667d5.png)
  
  ***
  ### **Core Katmanı** 
**Core Katmanı**, tüm proje/lerde kullanılcak base kodlar yazılır. Bu katmanda alt klasörler oluşturarak diğer katmanlar için evrensel kodları yazarız. Bu katmanda DataAccess , Entities ,  Utilities, Aspect, CrossCuttingConcerns olmak üzere beş adet klasör bulunmaktadır.

- **DataAccess** klasörü DataAccess Katmanı ile ilgili nesneleri, **Entities** klasörü Entities katmanı ile ilgili nesneleri tutmak için oluşturulmuştur.
- **Utilities** klasörü sistemi oluştururken kullandığımız toolları içeren katmandır. Response/request başarılı gerçekleşip gerçekleşmediğine dair kodları, yüklenecek dosya varsa aynı isimde yüklenmesini önleyici kodları içerir.
- **CrossCuttingConcerns** klasörü loglama,validation vb. işlemlerin yazıldığı kodları içerir.
- **Aspect** klasörü  CrossCuttingConcerns klasöründeki işlemleri business katmanındaki kodlara entegre ederken hangi işlemin önce ya da sonra yapılacağını düzenleyen kod bloklarını içerir.
 ***
![core](https://user-images.githubusercontent.com/77885953/176686008-4a47df11-f46f-467b-9fb2-eef381567d0e.png)

***
### **WebAPI  Katmanı** 
**WebAPI  Katmanı**, backend kodlarıyla frontend arasındaki bağlantıyı sağlar. Controllers kalsörü, startup.cs ve program.cs dosyalarından oluşur.

-  **Controllers** klasörü, sistemi kullanacak clientler(tarayıcı,mobil app), hangi operasyonlar için nasıl istekte bulunacağına dair kodları içerir. 
- **Startup.cs** Ioc configrationu sağlayarak controlleri eklediğimiz class
- **Program.cs** programı çalıştırdığımız main class
***
![webAPI](https://user-images.githubusercontent.com/77885953/176690582-5a2613e9-232f-4082-ab7b-8df439cf97cc.png)

 
 
