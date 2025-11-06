# 📷 QrCodeService & 📦 BarcodeService

QrCodeService is a lightweight and modular backend API built with ASP.NET Core that generates downloadable QR codes and barcodes from user-provided data. It’s ideal for websites, business cards, marketing materials, inventory systems, and any scenario where quick access or identification via code is needed.

---

## 📦 Project Structure

- `Controllers` – RESTful API endpoints for QR and barcode generation  
- `Services` – Logic for generating QR codes (QRCoder) and barcodes (ZXing.Net)  
- `Program.cs` – Application startup and dependency injection  
- `wwwroot` (optional) – Static file hosting for saved images

---

## 🚀 Features

### ✅ QR Code Endpoints (`/api/qr`)
- Generate QR code from any valid URL  
- Generate QR code from plain text  
- Generate QR code from email address  
- Generate QR code from phone number  
- Generate QR code from WiFi credentials (SSID, password, encryption)  
- Return QR code as downloadable PNG image  
- Integrated Swagger UI for testing and documentation

### ✅ Barcode Endpoints (`/api/barcode`)
- Generate barcode from plain text  
- Generate barcode from phone number  
- Generate barcode from email address  
- Return barcode as downloadable PNG image  
- Uses CODE_128 format for broad compatibility

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
## 📄 License
This project is licensed under the MIT License. See the LICENSE file for details.
