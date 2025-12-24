# PaymentSystemSOLID

Bu proje, **SOLID prensiplerine uygun** olarak geliştirilmiş,
**WinForms tabanlı** basit bir **ödeme simülasyonu** uygulamasıdır.

---

## 🎯 Amaç

Bu projenin temel amacı, **SOLID prensiplerini tekrar etmek ve pekiştirmek**
üzere basit ama öğretici bir senaryo üzerinden uygulamalı bir mimari kurmaktır.

Farklı ödeme yöntemleri kullanılarak;

- Arayüz (UI) ile iş mantığının ayrıştırılması,
- Kodun **genişletilebilir** ancak **değiştirilmeye kapalı** olması,
- Bağımlılıkların somut sınıflara değil **arayüzlere** yönelmesi,
- Yeni özellik eklerken mevcut kodların bozulmaması hedeflenmiştir.


---

## 🚀 Proje Özeti

Uygulama içerisinde kullanıcı, bir ödeme yöntemi seçerek ödeme işlemini başlatır.
Seçilen ödeme yöntemine göre sistem, ilgili işlemi gerçekleştirir ve sonucu ekranda gösterir.

Yeni bir ödeme yöntemi eklemek için mevcut kodlara **dokunmadan**
sadece yeni bir sınıf eklemek yeterlidir.

---

## 🧠 Kullanılan Yazılım Prensipleri

- **SOLID Principles**
  - Single Responsibility Principle (SRP)
  - Open / Closed Principle (OCP)
  - Dependency Inversion Principle (DIP)

- **Design Patterns**
  - Strategy Pattern
  - Factory Pattern
  - Dependency Injection (Constructor Injection)
  - Reflection

