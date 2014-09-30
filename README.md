COMDBG 串口调试助手
======

This tool is C# Serial port debug assistant. It can send and receive data from serial port. The most importment thing is that it is concise and NO AD!

Note:

(1) In windows, Enter key repensented by "\r\n", So if you have pressed enter key, in string mode, the soft will send 0x10 0x13 two bytes to the serial port. In the Hex mode, the enter key character "\r\n" will be dropped. 

(2) If you want to input HEX directly, you should input like the following format:
     FF-34-56-90
