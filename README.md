# PraktikumGDI

Praktikum Bab 1.4: membuat objek gambar menggunakan perintah-perintah kelas **GDI+** pada C# Windows Forms.

## Identitas

- **Nama**: Dhaifan Ramadhani Juliawan
- **NPM**: _isi NPM_
- **Program Studi**: Teknik Informatika, Universitas Padjadjaran
- **Mata Kuliah**: _isi nama mata kuliah_

## Deskripsi Tugas

| No | Soal | Hasil |
|----|------|-------|
| 1 | Objek sederhana dengan 3-5 perintah GDI+ | Rumah sederhana (`Form1`) |
| 2 | Objek kompleks bermakna dengan minimal 10 perintah GDI+ | Pemandangan desa (`Form2`) |

## Hasil

### Soal 1: Rumah Sederhana

![Soal 1](screenshots/soal1.png)

### Soal 2: Pemandangan Desa

![Soal 2](screenshots/soal2.png)

## Perintah GDI+ yang Digunakan

| Perintah | Fungsi |
|----------|--------|
| `Clear` | Mengisi seluruh area gambar dengan satu warna |
| `FillRectangle` | Menggambar persegi panjang berisi warna |
| `DrawRectangle` | Menggambar garis tepi persegi panjang |
| `FillPolygon` | Menggambar bentuk banyak sisi berisi warna |
| `FillEllipse` | Menggambar elips/lingkaran berisi warna |
| `DrawLine` | Menggambar garis lurus |
| `DrawString` | Menulis teks pada form |

## Struktur Project

```
PraktikumGDI/
├── Form1.cs          # Soal 1: objek sederhana
├── Form2.cs          # Soal 2: objek kompleks
├── Program.cs        # Entry point aplikasi
├── screenshots/      # Gambar hasil running
└── README.md
```

## Cara Menjalankan

1. Clone repository:
   ```bash
   git clone https://github.com/<username>/PraktikumGDI.git
   ```
2. Buka file `PraktikumGDI.sln` dengan **Visual Studio** (workload **.NET desktop development**).
3. Pada `Program.cs`, pilih form yang ingin dijalankan:
   ```csharp
   Application.Run(new Form1()); // Soal 1
   // Application.Run(new Form2()); // Soal 2
   ```
4. Tekan **F5** untuk menjalankan.

## Teknologi

- C# (.NET Framework)
- Windows Forms
- System.Drawing (GDI+)
- Visual Studio
