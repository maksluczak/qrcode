using Genocs.QRCodeGenerator.Encoder;

var generator = new QRCodeGenerator();
var data = generator.CreateQrCode("https://example.com", QRCodeGenerator.ECCLevel.Q);

var qr = new BitmapByteQRCode(data);
byte[] bmpBytes = qr.GetGraphic(5);

File.WriteAllBytes("qrcode.bmp", bmpBytes);