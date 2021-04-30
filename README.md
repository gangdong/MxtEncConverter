# MxtEncConverter

## Introduction
A tiny tool to translate the ATMEL maXTouch series touchscreen controller firmware file (specified .enc format) into a C header file.

ATMEL maXTouch touchscreen controller uses a encrypted bin-like format file for firmware file. On some occasion when need upgrading firmware on the smart phone, ODMs preferred the standard format file for compatibility.

This tool translates the specified format file into a Hex data array, outputs a standard C header file. 

Coding with C#.

## 介绍
一个小的windows平台下的工具，用于将ATMEL maXTouch 系列触摸屏控制芯片的固件文件转换为标准的 C 程序头文件。

ATMEL maXTouch触摸屏控制器使用指定格式二进制形式的文件用于固件文件。在某些情况下，需要升级固件时，手机制造商需要一种更通用的格式文件，以便于更好的兼容性。

这个工具会将固件文件转换为一个通用16进制数组的格式，输出到一个标准的C语言头文件中。以便用于软件集成开发的目的。

C# 语言开发。

## Usage
1. Build this project with VS.
2. Run "ENC2Array Converter.exe".<br>
3. Click "open" button to select the firmware file you want to translate.
4. The firmware self doesn't provide the build version information etc,. Family ID,Variant ID, version.. If you need, you can add these extra information into the output file by filling them into the corresponding text box. Click "convert" button to start translate, It will take some while and the data being translated will be displayed and refresh the text box during the time. Once translated is done, click "save" button to store the new file into the place where you want with a C standard header file.

## 使用
1. VS 下编译该工程
2. 运行 “Enc2Array Converter.exe”
3. 点击 “open” 按钮并选择需要转换的固件文件
4. 固件文件本身并不自带版本信息，如family ID,Variant ID, version等，如果需要可以将这些信息加入输出的文件中，只需要将这些信息填入相应的文本框即可。
5. 点击 “convert”按钮开始进行转换，这会需要一些时间。转换过程中转换的数据会实时显示在文本框内。转换完成后点击 “Save” 选择要存放的路径。保存生成的头文件。

![screenshot](https://cdn.jsdelivr.net/gh/gangdong/MxtEncConverter@master/screenshot.PNG)