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

 
 
