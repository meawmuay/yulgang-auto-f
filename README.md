# Yulgang ช่วยกดยาจากช่อง F1-F10

![](https://i.imgur.com/38WPQsE.png)

โปรแกรมนี้จัดทำขึ้นมาให้ใช้ฟรี เพื่อช่วยให้กดยาจากช่อง F1-F10 เช่นป้ายสนับสนุนที่ไม่สามารถใส่กล่องบอทได้

✅ โปรแกรมใช้งานฟรี\
✅ โปรแกรมทำเพียงแค่กดปุ่มให้ตามหน่วงเวลา ไม่ได้แก้ไขตัวเกมใด ๆ\
✅ เปิดรหัสโค้ด 100% (Open Source)
<br/>
<br/>
## เริ่มต้นใช้งาน

โปรแกรมนี้เขียนด้วยโปรแกรม Visual Studio 2017 และใช้ .NET Framework เวอร์ชั่น 4.5.0 เป็นอย่างต่ำ
### ดาวน์โหลด
[Yulgang Auto F Version 1.0.0.0](https://github.com/meawmuay/yulgang-auto-f/releases/download/v1.0.0.0/Yulgang.Auto.F.1.0.0.0.rar "Yulgang Auto F Latest Version")

### ติดตั้ง
ตัวโปรแกรมไม่มีความจำเป็นต้องติด แต่หากคุณยังไม่ได้ลง .NET Framework เวอร์ชั่น 4.5.0 หรือมากกว่า ดาวน์โหลดได้จากลิงค์ด้านล่าง

[Microsoft .NET Framework 4.6.1 (Web Installer)](https://www.microsoft.com/en-us/download/details.aspx?id=49981 "Microsoft .NET Framework 4.6.1 (Web Installer)")

รองรับระบบปฏิบัติการ
- Windows 7 SP1
- Windows 8
- Windows 8.1
- Windows 10
- Windows Server 2008 R2 SP1
- Windows Server 2012
- Windows Server 2012 R2

### วิธีใช้งาน
1. เปิดเกม แล้วกดเลือกหน้าจอเกม
2. เอายาที่ต้องการมาใส่ไว้ในช่อง F1-10 ในเกมตามต้องการ
3. เลือกปุ่ม F1-10 ตามที่เราตั้งในโปรแกรม แล้วเลือก หน่วงเวลาตามต้องการ
4. กดปุ่มเริ่มทำงาน


### หมายเหตุ
ทำไมถึงขึ้นตามรายการด้านล่างนี้
- Publisher : Unknown ในขณะที่เปิดโปรแกรม [(ตัวอย่าง)](https://i.imgur.com/peSlQDG.png "(ตัวอย่าง)")
- ตอนดาวน์โหลดเสร็จ บราวเซอร์แจ้งว่า "ไฟล์นี้ไม่ได้มีการดาวน์โหลดเป็นที่แพร่หลายและอาจเป็นอันตราย" หรือ "This file is not commonly downloaded and may be dangerous." [(ตัวอย่าง)](https://i.imgur.com/FkxEtZs.png "(ตัวอย่าง)")

เนื่องมาจาก ตัวโปรแกรมไม่ได้ Publish ด้วย Code Signing Certificate (จำเป็นต้องซื้อและยืนยันตัวตน) และตัวโปรแกรมต้องการสิทธิ์ Administrator เพื่อเข้าถึงฟังก์ชั่นตามด้านล่างนี้จาก Library user32.dll
- GetForegroundWindow
- SetForegroundWindow
- GetWindowText
- GetWindowThreadProcessId


## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details