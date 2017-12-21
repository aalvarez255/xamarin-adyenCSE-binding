# Xamarin bindings for AdyenCSE
Xamarin.Android and Xamarin.iOS binding for AdyenCSE native libraries.
Links to official native libraries:
* Adyen CSE for Android: https://github.com/Adyen/adyen-cse-android
* Adyen CSE for iOS: https://github.com/Adyen/adyen-cse-ios

## Usage on Xamarin.Android apps
1. Build Android binding project
2. Add a project reference to the android binding project
3. Code to generate the credit card encrypted data:
```c#
var publicKey = "10001|B243E873CB9220BAFE71...";
var card = new Adyen.Com.Adyencse.Pojo.Card()
{
    Number = "55551...",
    CardHolderName = "John A...",
    Cvc = "737",
    ExpiryMonth = "08",
    ExpiryYear = "2018",
    GenerationTime = new Java.Util.Date()
};

string encryptedData = card.Serialize(publicKey);
```

## Usage on Xamarin.iOS apps
1. Build iOS binding project
2. Add a project reference to the iOS binding project
2. Code to generate the credit card encrypted data:
```c#
var publicKey = "10001|B243E873CB9220BAFE71...";
var card = new AdyenCSE.iOS.ADYCard()
{
    Number = "55551...",
    CardHolderName = "John A...",
    Cvc = "737",
    ExpiryMonth = "08",
    ExpiryYear = "2018",
    Generationtime = new NSDate()
};

string encryptedData = AdyenCSE.iOS.ADYEncrypter.Encrypt(card.Encode, publicKey);
```

## :warning: Visual Studio errors
There's a known bug with Visual Studio regarding xamarin binding projects. It's usual that the referenced namespaces are marked as errors in Intellisense console.
However, these Intellisense errors can be ignored because the build process is completed successfuly.
