using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace AdyenCSE.iOS
{
    // @interface ADYAESCCMCryptor : NSObject
    [BaseType(typeof(NSObject))]
    interface ADYAESCCMCryptor
    {
        // +(NSData * _Nullable)encrypt:(NSData * _Nonnull)data withKey:(NSData * _Nonnull)key iv:(NSData * _Nonnull)iv;
        [Static]
        [Export("encrypt:withKey:iv:")]
        [return: NullAllowed]
        NSData Encrypt(NSData data, NSData key, NSData iv);

        // +(NSData * _Nullable)encrypt:(NSData * _Nonnull)data withKey:(NSData * _Nonnull)key iv:(NSData * _Nonnull)iv tagLength:(size_t)tagLength adata:(NSData * _Nullable)adata;
        [Static]
        [Export("encrypt:withKey:iv:tagLength:adata:")]
        [return: NullAllowed]
        NSData Encrypt(NSData data, NSData key, NSData iv, nuint tagLength, [NullAllowed] NSData adata);
    }

    // @interface ADYCard : NSObject
    [BaseType(typeof(NSObject))]
    interface ADYCard
    {
        // @property (nonatomic, strong) NSDate * _Nullable generationtime;
        [NullAllowed, Export("generationtime", ArgumentSemantic.Strong)]
        NSDate Generationtime { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable number;
        [NullAllowed, Export("number", ArgumentSemantic.Strong)]
        string Number { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable holderName;
        [NullAllowed, Export("holderName", ArgumentSemantic.Strong)]
        string HolderName { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable cvc;
        [NullAllowed, Export("cvc", ArgumentSemantic.Strong)]
        string Cvc { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable expiryMonth;
        [NullAllowed, Export("expiryMonth", ArgumentSemantic.Strong)]
        string ExpiryMonth { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable expiryYear;
        [NullAllowed, Export("expiryYear", ArgumentSemantic.Strong)]
        string ExpiryYear { get; set; }

        // +(ADYCard * _Nullable)decode:(NSData * _Nonnull)json error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("decode:error:")]
        [return: NullAllowed]
        ADYCard Decode(NSData json, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)encode;
        [NullAllowed, Export("encode")]
        NSData Encode { get; }
    }

    // @interface ADYCryptor : NSObject
    [BaseType(typeof(NSObject))]
    interface ADYCryptor
    {
        // +(void)setMsgPrefix:(NSString * _Nullable)prefix;
        [Static]
        [Export("setMsgPrefix:")]
        void SetMsgPrefix([NullAllowed] string prefix);

        // +(void)setMsgSeparator:(NSString * _Nullable)separator;
        [Static]
        [Export("setMsgSeparator:")]
        void SetMsgSeparator([NullAllowed] string separator);

        // +(NSString * _Nullable)encrypt:(NSData * _Nonnull)data publicKeyInHex:(NSString * _Nonnull)keyInHex;
        [Static]
        [Export("encrypt:publicKeyInHex:")]
        [return: NullAllowed]
        string Encrypt(NSData data, string keyInHex);

        // +(NSData * _Nullable)aesEncrypt:(NSData * _Nonnull)data withKey:(NSData * _Nonnull)key iv:(NSData * _Nonnull)iv;
        [Static]
        [Export("aesEncrypt:withKey:iv:")]
        [return: NullAllowed]
        NSData AesEncrypt(NSData data, NSData key, NSData iv);

        // +(NSData * _Nullable)rsaEncrypt:(NSData * _Nonnull)data withKeyInHex:(NSString * _Nonnull)keyInHex;
        [Static]
        [Export("rsaEncrypt:withKeyInHex:")]
        [return: NullAllowed]
        NSData RsaEncrypt(NSData data, string keyInHex);

        // +(NSData * _Nonnull)dataFromHex:(NSString * _Nonnull)hex;
        [Static]
        [Export("dataFromHex:")]
        NSData DataFromHex(string hex);

        // +(NSData * _Nullable)sha1FromStringInHex:(NSString * _Nonnull)stringInHex;
        [Static]
        [Export("sha1FromStringInHex:")]
        [return: NullAllowed]
        NSData Sha1FromStringInHex(string stringInHex);
    }

    // @interface ADYEncrypter : ADYCryptor
    [BaseType(typeof(ADYCryptor))]
    interface ADYEncrypter
    {
        // +(NSString * _Nullable)encrypt:(NSData * _Nonnull)data publicKeyInHex:(NSString * _Nonnull)keyInHex;
        [Static]
        [Export("encrypt:publicKeyInHex:")]
        [return: NullAllowed]
        string Encrypt(NSData data, string keyInHex);
    }

    // @interface ADYRSACryptor : NSObject
    [BaseType(typeof(NSObject))]
    interface ADYRSACryptor
    {
        // +(NSData * _Nullable)encrypt:(NSData * _Nonnull)data withKeyInHex:(NSString * _Nonnull)keyInHex;
        [Static]
        [Export("encrypt:withKeyInHex:")]
        [return: NullAllowed]
        NSData Encrypt(NSData data, string keyInHex);
    }

    // @interface AdyenUtil (NSDictionary)
    [Category]
    [BaseType(typeof(NSDictionary))]
    interface NSDictionary_AdyenUtil
    {
        // -(NSString * _Nonnull)encodeFormData __attribute__((deprecated("Use -ady_encodeFormData instead.")));
        [Export("encodeFormData")]
        [Static]
        string EncodeFormData { get; }

        // -(NSString * _Nonnull)ady_encodeFormData;
        [Export("ady_encodeFormData")]
        [Static]
        string Ady_encodeFormData { get; }
    }

    // @interface AdyenURLEncoding (NSString)
    [Category]
    [BaseType(typeof(NSString))]
    interface NSString_AdyenURLEncoding
    {
        // -(NSString * _Nullable)urlEncodeUsingEncoding:(NSStringEncoding)encoding __attribute__((deprecated("Use -ady_URLEncodedString instead.")));
        [Export("urlEncodeUsingEncoding:")]
        [return: NullAllowed]
        [Static]
        string UrlEncodeUsingEncoding(nuint encoding);
    }

    // @interface AdyenUtil (NSString)
    [Category]
    [BaseType(typeof(NSString))]
    interface NSString_AdyenUtil
    {
        // -(BOOL)isHexString __attribute__((deprecated("Use -ady_isHexString instead.")));
        [Export("isHexString")]
        [Static]
        bool IsHexString { get; }

        // -(BOOL)ady_isHexString;
        [Export("ady_isHexString")]
        [Static]
        bool Ady_isHexString { get; }

        // -(NSString * _Nullable)URLEncodedString __attribute__((deprecated("Use -ady_URLEncodedString instead.")));
        [NullAllowed, Export("URLEncodedString")]
        [Static]
        string URLEncodedString { get; }

        // -(NSString * _Nullable)ady_URLEncodedString;
        [NullAllowed, Export("ady_URLEncodedString")]
        [Static]
        string Ady_URLEncodedString { get; }
    }

    [Static]
    partial interface Constants
    {
        // extern double AdyenCSEVersionNumber;
        [Field("AdyenCSEVersionNumber", "__Internal")]
        double AdyenCSEVersionNumber { get; }

        // extern const unsigned char [] AdyenCSEVersionString;
        [Field("AdyenCSEVersionString", "__Internal")]
        NSString AdyenCSEVersionString { get; }
    }
}

