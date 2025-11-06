# 📷 QrCodeService

QrCodeService is a lightweight and modular backend API built with ASP.NET Core that generates downloadable QR codes from user-provided URLs. It’s ideal for websites, business cards, marketing materials, and any scenario where quick access via QR is needed.

---

## 📦 Project Structure

- `Controllers` – RESTful API endpoints  
- `Services` – QR code generation logic using QRCoder  
- `Program.cs` – Application startup and dependency injection  
- `wwwroot` (optional) – Static file hosting for saved QR images

---

## 🚀 Features

- Generate QR code from any valid URL  
- Return QR code as downloadable PNG image  
- Simple GET endpoint with query parameter  
- Integrated Swagger UI for testing and documentation  
- Easily extendable to support other QR types (text, WiFi, phone, etc.)

---

## 🛠 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)  
- Optional: Postman or Swagger for testing  
- Optional: Git for cloning the repository

---

## ⚙️ How to Run

```bash
git clone https://github.com/your-username/QrCodeService.git
cd QrCodeService
dotnet restore
dotnet run
```
## 📸 Example Usage
```bash
GET /api/qr?url=https://example.com
```
---
## ✨ Future Enhancements
- Save QR generation history to SQL Server
- Add JWT-based authentication
- Support for additional QR types (WiFi, SMS, vCard)
- Email delivery of generated QR codes
- Frontend integration with Blazor or React
---
## 📄 License
This project is licensed under the MIT License. See the LICENSE file for details.
