# Bebek Uygulaması

Bu proje, C# dilinde yazılmış basit bir konsol uygulamasıdır. Uygulama, `Bebek` adlı bir sınıf oluşturur ve bu sınıfın çeşitli özelliklerini ve constructor'larını kullanarak bebek nesneleri oluşturur.

## Özellikler

- `Bebek` sınıfı, `Doğum Tarihi`, `Ad` ve `Soyad` özelliklerine sahiptir.
- `Bebek` sınıfı için iki adet constructor tanımlanmıştır:
  - Parametre almayan default constructor.
  - `Ad` ve `Soyad` parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.
- Her iki constructor da bebek nesnesi oluşturulduğunda konsol ekranında bir "Ingaaaa" yazısı gösterir ve doğum tarihini o anki tarih olarak atar.

## Kullanım

### Default Constructor

Parametre almayan default constructor kullanarak bir bebek nesnesi oluşturabilirsiniz:

Bebek bebek1 = new Bebek(); Console.WriteLine($"Bebek Adı : {bebek1.Ad} Soyadı : {bebek1.Soyad} , D.T : {bebek1.Dogum}");


### Parametre Alan Constructor

`Ad` ve `Soyad` parametrelerini alarak bir bebek nesnesi oluşturabilirsiniz:

Bebek bebek2 = new Bebek("Efe", "Karahanlı"); Console.WriteLine($"Bebek Adı : {bebek2.Ad} Soyadı : {bebek2.Soyad} , D.T : {bebek2.Dogum}");



### Bebek Nesnelerini Toplu Yazdırma

Birden fazla bebek nesnesini bir dizi veya listeye ekleyerek toplu olarak yazdırabilirsiniz:


## Gereksinimler

- .NET 8
- C# 12.0

## Kurulum

1. Bu projeyi klonlayın veya indirin.
2. Proje dizinine gidin.
3. `dotnet run` komutunu kullanarak projeyi çalıştırın.


## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.

