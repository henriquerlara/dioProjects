# Phone Abstraction Project

## Description

This project is a **Phone Abstraction System** built in C#. It demonstrates the use of object-oriented programming principles by modeling a generic smartphone system. The system includes an abstract class `Smartphone` and two specific implementations: `Nokia` and `Iphone`. Each phone type has its own unique features, while sharing common functionalities like making calls, receiving calls, and installing apps. Additionally, a `Charger` class is included to simulate device charging.

## Features

- **Make and Receive Calls**: Both `Nokia` and `Iphone` can make and receive calls, displaying the relevant details.
- **Send Messages**: Send messages through a shared or customized messaging system (e.g., SMS for `Nokia` and iMessage for `Iphone`).
- **Install Applications**: Install apps on each phone. The installation process is customized for each type (e.g., Nokia firmware and iOS App Store).
- **Firmware Updates**: Update the firmware of `Nokia` phones with a new version.
- **iOS Updates**: Update the iOS version for `Iphone` devices.
- **Device Charging**: Use the `Charger` class to simulate charging any smartphone with a specific brand and power output.

## Usage

1. **Create Smartphones**: Instantiate `Nokia` and `Iphone` objects by specifying details such as phone number, model, IMEI, memory, and firmware or iOS version.
2. **Make and Receive Calls**: Use the `Call` and `ReceiveCall` methods to simulate making and receiving phone calls.
3. **Send Messages**: Send messages using the `SendMessage` method for `Nokia` or the `SendiMessage` method for `Iphone`.
4. **Install Apps**: Install applications using the `InstallApp` method, which behaves differently for each type of smartphone.
5. **Perform Updates**:
   - Update firmware for `Nokia` phones using the `UpdateFirmware` method.
   - Update iOS for `Iphone` devices using the `UpdateiOS` method.
6. **Charge Smartphones**: Use the `Charger` class to simulate charging devices with specific power output and brand.