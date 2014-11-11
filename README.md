[Serail port debug assistant](http://wenhuix.github.io/project/comdbg.html)
======
This tool is C# Serial port debug assistant. It can send and receive data from serial port. The most importment thing is that it is concise and NO AD!
### Note:
1. In windows, Enter key repensented by "\r\n", So if you have pressed enter key, in string mode, the soft will send 0x10 0x0A two bytes to the serial port. In the Hex mode, the enter key character "\r\n" will be dropped. 
2. If you want to input HEX directly, you should input like the following format:
     FF-34-56-90

### Feature:
* Automatic find and list avaliable serial port.
* Send data automatically.
* Data can be displayd as string or Hex.
* Concise and open source.
* No dependency

[串口调试助手](http://wenhuix.github.io/project/comdbg.html)
======
这是C#串口调试工具，基于.Net4.0，实现基本的串口通信功能，重要的是无广告以及开源。
### 注意：

1. 在Windows系统中，回车键是以"\r\n"表示，如果在发送文本框中输入了回车键，在String模式下发送的数据将包括 0x0D 0x0A 两个字节。在Hex模式下，将无法输入回车键，如果需要回车，用0x0D 0x0A代替。
2. Hex模式下，直接输入16进制数，输入的格式为：
     FF-34-56-90

### 特点：
* 自动查找并列出可用串口。
* 可设置自动发送。
* 可切换Hex和String显示。
* 界面简洁，代码开源。
* 无附加依赖库。

如果觉得还可以，请点个赞 :)

![Alt text](/../screenshot/Screenshot.jpg?raw=true "Screen shot")
