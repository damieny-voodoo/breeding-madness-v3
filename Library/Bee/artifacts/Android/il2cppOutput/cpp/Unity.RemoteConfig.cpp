#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename T1>
struct VirtualActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct VirtualActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtualFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R, typename T1, typename T2, typename T3>
struct VirtualFuncInvoker3
{
	typedef R (*Func)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Action`1<UnityEngine.AsyncOperation>
struct Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB;
// System.Action`1<Unity.RemoteConfig.ConfigResponse>
struct Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E;
// System.Action`1<System.Object>
struct Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Text.Encoding>
struct Dictionary_2_t87EDE08B2E48F793A22DE50D6B3CC2E7EBB2DB54;
// System.Collections.Generic.Dictionary`2<System.Object,Unity.RemoteConfig.ConfigResponse>
struct Dictionary_2_tBAAB91981CCB60D9FC4599D3CAA138B40CBA2CCF;
// System.Collections.Generic.Dictionary`2<System.Object,System.Object>
struct Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA;
// System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.ConfigResponse>
struct Dictionary_2_t1350928D43387352EDB22C6979983B8129804127;
// System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.RuntimeConfig>
struct Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D;
// System.Collections.Generic.Dictionary`2<System.String,System.String>
struct Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83;
// System.EventHandler`1<Newtonsoft.Json.Serialization.ErrorEventArgs>
struct EventHandler_1_t69462DFC2F2C8D7576BEE9D1F5BB6C2E55B2C380;
// System.Func`1<Newtonsoft.Json.Serialization.IReferenceResolver>
struct Func_1_t78E8B13F3C7D6CC3EB821B4F5D26999D062417E2;
// System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>
struct Func_1_t2A08DEC58BFB76B9DDF49BCF555A3342127229B5;
// System.Func`2<Newtonsoft.Json.Linq.JProperty,System.String>
struct Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879;
// System.Func`2<System.Object,System.Object>
struct Func_2_tACBF5A1656250800CE861707354491F0611F6624;
// System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>
struct Func_3_t6491300EDE89815C2EE58365B51E0AE133B267AD;
// System.Func`3<System.Object,System.Object,System.Boolean>
struct Func_3_tFCEB9D8CEAECBF6D0AD5440F96C6F9010270CE79;
// System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JProperty>
struct IEnumerable_1_tF4128BC7B1616BB3AC4032BFE4ADB2D80CFB26CE;
// System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>
struct IEnumerable_1_t1447BF8E1A962EF1787C1E07658EB94E72BA2CEF;
// System.Collections.Generic.IEnumerable`1<System.Object>
struct IEnumerable_1_tF95C9E01A913DD50575531C8305932628663D9E9;
// System.Collections.Generic.IEnumerable`1<System.String>
struct IEnumerable_1_t349E66EC5F09B881A8E52EE40A1AB9EC60E08E44;
// System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,Newtonsoft.Json.Linq.JToken>>
struct IEnumerator_1_tB643E521895AE2CA45F187028EC1470EC9DCEEDA;
// System.Collections.Generic.IEqualityComparer`1<System.String>
struct IEqualityComparer_1_tAE94C8F24AD5B94D4EE85CA9FC59E3409D41CAF7;
// System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>
struct IList_1_t106D4C1340745E38431865BBEA6AE170A4713431;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Object,System.Object>
struct KeyCollection_tB45A861D090B15129521119AE48ED3813820A974;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,Unity.RemoteConfig.ConfigResponse>
struct KeyCollection_t0A9920E929E6DC22266AFBE84DE8CBED675E3E21;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,Unity.RemoteConfig.RuntimeConfig>
struct KeyCollection_tDABE6E934B2EF300EC234A664076A202E3BFA4BE;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,System.String>
struct KeyCollection_t2EDD317F5771E575ACB63527B5AFB71291040342;
// System.Collections.Generic.List`1<System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>>
struct List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C;
// System.Collections.Generic.List`1<System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>>
struct List_1_t0829E916C4AAB917E57526AEED3AB682DB994946;
// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,Unity.RemoteConfig.ConfigResponse>
struct ValueCollection_t9C389C48BBCBE0D48B7470BA5A91403D84A8ADF2;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,Unity.RemoteConfig.RuntimeConfig>
struct ValueCollection_tB260FA65D3210B4C8615A8D9030D916502A7E0C2;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,System.String>
struct ValueCollection_t238D0D2427C6B841A01F522A41540165A2C4AE76;
// System.Collections.Generic.Dictionary`2/Entry<System.String,Unity.RemoteConfig.ConfigResponse>[]
struct EntryU5BU5D_t6F91280F546B7A76A0B8019B0F6B78C75AA07FAB;
// System.Collections.Generic.Dictionary`2/Entry<System.String,Unity.RemoteConfig.RuntimeConfig>[]
struct EntryU5BU5D_tED2BF2245A08F0596C0CECAE9FE4C67FCBCD8326;
// System.Collections.Generic.Dictionary`2/Entry<System.String,System.String>[]
struct EntryU5BU5D_t1AF33AD0B7330843448956EC4277517081658AE7;
// System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>[]
struct Func_1U5BU5D_t35E715A5393234AC7F32707564384207E5B82905;
// System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>[]
struct Func_3U5BU5D_t350FFC71609BA6C4B7770BB3442A641932D33B03;
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// Newtonsoft.Json.Linq.JTokenType[]
struct JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
// System.ComponentModel.AddingNewEventHandler
struct AddingNewEventHandler_tD9BAC60F604446ED14967643F63A83CE2A5C3701;
// UnityEngine.AndroidJavaClass
struct AndroidJavaClass_tE6296B30CC4BF84434A9B765267F3FD0DD8DDB03;
// UnityEngine.AndroidJavaObject
struct AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0;
// UnityEngine.AsyncOperation
struct AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C;
// UnityEngine.Networking.CertificateHandler
struct CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804;
// System.Globalization.CodePageDataItem
struct CodePageDataItem_t52460FA30AE37F4F26ACB81055E58002262F19F2;
// Unity.RemoteConfig.ConfigManagerImpl
struct ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7;
// System.Globalization.CultureInfo
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0;
// System.Text.DecoderFallback
struct DecoderFallback_t7324102215E4ED41EC065C02EB501CB0BC23CD90;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// UnityEngine.Networking.DownloadHandler
struct DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB;
// UnityEngine.Networking.DownloadHandlerBuffer
struct DownloadHandlerBuffer_t34C626F6513FA9A44FDDDEE85455CF2CD9DA5974;
// System.Text.Encoder
struct Encoder_tAF9067231A76315584BDF4CD27990E2F485A78FA;
// System.Text.EncoderFallback
struct EncoderFallback_tD2C40CE114AA9D8E1F7196608B2D088548015293;
// System.Text.Encoding
struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095;
// System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2;
// System.IO.FileStream
struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8;
// UnityEngine.GlobalJavaObjectRef
struct GlobalJavaObjectRef_t20D8E5AAFC2EB2518FCABBF40465855E797FF0D8;
// Newtonsoft.Json.Serialization.IContractResolver
struct IContractResolver_t7EC502F5FCA86DD95579A92A1E0116BE32D6340B;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// System.Collections.IEqualityComparer
struct IEqualityComparer_tEF8F1EC76B9C8E76695BE848D41E6B147928D1C1;
// System.IFormatProvider
struct IFormatProvider_tC202922D43BFF3525109ABF3FB79625F5646AB52;
// Newtonsoft.Json.Serialization.ISerializationBinder
struct ISerializationBinder_t3C8B850335FB40001C9201981439AE77B430031F;
// Newtonsoft.Json.Serialization.ITraceWriter
struct ITraceWriter_t44C99CB7D5AB59A077F569914E56DAD66B5A41EF;
// Newtonsoft.Json.Linq.JContainer
struct JContainer_tFD3E2CD9B9D8D3CD73133B11A1F6BE77C5C8F95A;
// Newtonsoft.Json.Linq.JObject
struct JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1;
// Newtonsoft.Json.Linq.JProperty
struct JProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4;
// Newtonsoft.Json.Linq.JPropertyKeyedCollection
struct JPropertyKeyedCollection_t4A44691A9942B8A7AEB4016F7405BF388D1E0632;
// Newtonsoft.Json.Linq.JToken
struct JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3;
// Newtonsoft.Json.Linq.JTokenEqualityComparer
struct JTokenEqualityComparer_t2B7EB6B1D12A8C94152AB2E690CC45F185373C46;
// Newtonsoft.Json.JsonSerializerSettings
struct JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF;
// System.ComponentModel.ListChangedEventHandler
struct ListChangedEventHandler_tDBF36F3E2C6B7538106878E1D5A7553C5EA77616;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Collections.Specialized.NotifyCollectionChangedEventHandler
struct NotifyCollectionChangedEventHandler_t521FADBD1190F88022BC2160A5F82FDFC08364AF;
// System.ComponentModel.PropertyChangedEventHandler
struct PropertyChangedEventHandler_tF1250C146BE6FB43477D29C5D18A10B6329419DA;
// System.ComponentModel.PropertyChangingEventHandler
struct PropertyChangingEventHandler_tF293724DEA588C35A7E94C4F4413AEE6438FE9CD;
// Unity.RemoteConfig.RCUnityWebRequest
struct RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26;
// Unity.RemoteConfig.RuntimeConfig
struct RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99;
// Microsoft.Win32.SafeHandles.SafeFileHandle
struct SafeFileHandle_t033FA6AAAC65F4BB25F4CBA9A242A58C95CD406E;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// System.Threading.SemaphoreSlim
struct SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2;
// System.IO.Stream
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE;
// System.IO.StreamWriter
struct StreamWriter_t6E7DF7D524AA3C018A65F62EE80779873ED4D1E4;
// System.String
struct String_t;
// System.Threading.Tasks.Task
struct Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572;
// Unity.RemoteConfig.UnityAttributes
struct UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04;
// UnityEngine.Networking.UnityWebRequest
struct UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F;
// UnityEngine.Networking.UnityWebRequestAsyncOperation
struct UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C;
// UnityEngine.Networking.UploadHandler
struct UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6;
// UnityEngine.Networking.UploadHandlerRaw
struct UploadHandlerRaw_t0A24CF320CDF16F1BC6C5C086DE71A1908CBB91A;
// System.Uri
struct Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E;
// System.UriParser
struct UriParser_t920B0868286118827C08B08A15A9456AF6C19D81;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// Unity.RemoteConfig.ConfigManagerImpl/<>c__DisplayClass35_0
struct U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548;
// Newtonsoft.Json.Linq.JProperty/JPropertyList
struct JPropertyList_t53D97F8AB016B10A00D616C620766D38449D8C98;
// Unity.RemoteConfig.RuntimeConfig/<>c
struct U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9;
// System.IO.Stream/ReadWriteTask
struct ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05;
// System.Uri/UriInfo
struct UriInfo_t5F91F77A93545DDDA6BB24A609BAF5E232CC1A09;

IL2CPP_EXTERN_C RuntimeClass* Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AndroidJavaClass_tE6296B30CC4BF84434A9B765267F3FD0DD8DDB03_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ApplicationInstallMode_tC04028D1A53D6C33BFE4678D81B891F6214C7CDA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_t1350928D43387352EDB22C6979983B8129804127_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DownloadHandlerBuffer_t34C626F6513FA9A44FDDDEE85455CF2CD9DA5974_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_1_tB643E521895AE2CA45F187028EC1470EC9DCEEDA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* JsonConvert_t01281FFED14CC2AEFABB6608315D90ED5C46E0C2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t0829E916C4AAB917E57526AEED3AB682DB994946_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimeObject_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimePlatform_t9A8AAF204603076FCAAECCCC05DA386AEE7BF66E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UploadHandlerRaw_t0A24CF320CDF16F1BC6C5C086DE71A1908CBB91A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD;
IL2CPP_EXTERN_C String_t* _stringLiteral07209D8AB943F98AB103AED7BA2AB574E0E5C0D2;
IL2CPP_EXTERN_C String_t* _stringLiteral09DBABCF47D177922630CF7626523A2E035CFB16;
IL2CPP_EXTERN_C String_t* _stringLiteral0C45DB50527FCFAD456E74EB416B617329505309;
IL2CPP_EXTERN_C String_t* _stringLiteral114BCE5E07B2B89600E7B0C1E7991AC7281CDDA6;
IL2CPP_EXTERN_C String_t* _stringLiteral14E338D17C42E552FA7AF42CDAE40CA1F0E8A04D;
IL2CPP_EXTERN_C String_t* _stringLiteral17A5AD13F3B52AA01A6CBB2F9F414BE34E8AB9A9;
IL2CPP_EXTERN_C String_t* _stringLiteral1B62E5629805E3224249BCAA0D9ECBB4C84AE48B;
IL2CPP_EXTERN_C String_t* _stringLiteral203DD5C89072A85E4D8D935A3028CCC3E3855F85;
IL2CPP_EXTERN_C String_t* _stringLiteral20BB23A674F385779F076FBBECD1E67230DE5751;
IL2CPP_EXTERN_C String_t* _stringLiteral220702BCC5C1C54BEDED83D77E4E5425AFBCE65C;
IL2CPP_EXTERN_C String_t* _stringLiteral2857526C6CA87F5E42495CA8FC55534F69207042;
IL2CPP_EXTERN_C String_t* _stringLiteral29AA1803EE63BE5E6E59AD64966B8601C7579987;
IL2CPP_EXTERN_C String_t* _stringLiteral2BAE1EC4AD1D2DAA7FBBE5C17BB3EC9CC7AB734A;
IL2CPP_EXTERN_C String_t* _stringLiteral2D39827A7835A83EF049D5A7A806C2C7C6EC42FA;
IL2CPP_EXTERN_C String_t* _stringLiteral35B44AA64754DEDC52915E7F763C081CF5B004D9;
IL2CPP_EXTERN_C String_t* _stringLiteral3DF22942163DC77B0DAEE048614E29D96E4493DC;
IL2CPP_EXTERN_C String_t* _stringLiteral4A25544E6922FB90F714C62E18485457D83197D5;
IL2CPP_EXTERN_C String_t* _stringLiteral4B0E509E3481549FC8F096287EFB425FAAFC38A4;
IL2CPP_EXTERN_C String_t* _stringLiteral561357A43AFC43D221B9F230B04E836DD73101EB;
IL2CPP_EXTERN_C String_t* _stringLiteral59C3175CF396D80239CBF63054A92BA6236C8CD2;
IL2CPP_EXTERN_C String_t* _stringLiteral5A8A967B3F8A5D1396E5B6A1DD09C7E00F29A21B;
IL2CPP_EXTERN_C String_t* _stringLiteral5B58EBE31E594BF8FA4BEA3CD075473149322B18;
IL2CPP_EXTERN_C String_t* _stringLiteral5F10B8B394D955D4DDBF1EDA2398E483B471C117;
IL2CPP_EXTERN_C String_t* _stringLiteral60EF1C26D54FB5A5DFE16A86970F69F7F4AB4D34;
IL2CPP_EXTERN_C String_t* _stringLiteral64058CC688A96A90239811EF06C9D20DB0499C3E;
IL2CPP_EXTERN_C String_t* _stringLiteral68475E64D3943C9BB7F5E25BD175FCA30A7BAB36;
IL2CPP_EXTERN_C String_t* _stringLiteral6B888C10342DD1C8AE97657EEA10E4A180B3258E;
IL2CPP_EXTERN_C String_t* _stringLiteral6BF72B6E90E497119B7EEA6511CFEB06890528B4;
IL2CPP_EXTERN_C String_t* _stringLiteral6DB33ADD301402F08747C4EE933A8EF10A8128F7;
IL2CPP_EXTERN_C String_t* _stringLiteral77EE5971434CDE6F74A1DAE44D94954E1624D77C;
IL2CPP_EXTERN_C String_t* _stringLiteral7BFA33A11F0B12AF1B7FA1D9BA996EAE1EF77B49;
IL2CPP_EXTERN_C String_t* _stringLiteral7D63FA1B6FEDA67964D3FCDCB12764101D65571C;
IL2CPP_EXTERN_C String_t* _stringLiteral7D8699446610575017F99BEA3E02DCF807B45CAB;
IL2CPP_EXTERN_C String_t* _stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2;
IL2CPP_EXTERN_C String_t* _stringLiteral824A9D9A2BAC4D0020E78F328C3A5908C950B369;
IL2CPP_EXTERN_C String_t* _stringLiteral82F3BE480580F58EE08D437D524BB2A9AD438EE4;
IL2CPP_EXTERN_C String_t* _stringLiteral8AE263ACD0B994D3BE52A427E3279DE126BB0E6A;
IL2CPP_EXTERN_C String_t* _stringLiteral8D927104AAFE48366762B70DC5E7CA34D1C0D5BE;
IL2CPP_EXTERN_C String_t* _stringLiteral8FB5CD3CB553F7B121B1233133C592DDBD928A75;
IL2CPP_EXTERN_C String_t* _stringLiteral903B8C1EF36009AA876A865426B6853A18141FFA;
IL2CPP_EXTERN_C String_t* _stringLiteral91C5120C562094A257C8FC3C676B64F1E0403765;
IL2CPP_EXTERN_C String_t* _stringLiteral96681A2B198D42859DB500CC97021274BD2004F1;
IL2CPP_EXTERN_C String_t* _stringLiteral996E5360F80E16B2189CC1E536C91CE68083F694;
IL2CPP_EXTERN_C String_t* _stringLiteral9D5A3AE3D2B0B5E5AF5AB489000D9B88FA11E907;
IL2CPP_EXTERN_C String_t* _stringLiteral9FCE27425740686001DEDF0E34460EF2890AB0C3;
IL2CPP_EXTERN_C String_t* _stringLiteralA25C69590D313E80E32DAF839FFE871D0B53E5EB;
IL2CPP_EXTERN_C String_t* _stringLiteralA31F29C367D53AD7C824C843BE0DEB228E4B5EBC;
IL2CPP_EXTERN_C String_t* _stringLiteralA3DC94CE2E4ADB08254413E0E3386625CB614D76;
IL2CPP_EXTERN_C String_t* _stringLiteralA56C9155AC403BB1318263AA70D1C16BBC8123D1;
IL2CPP_EXTERN_C String_t* _stringLiteralA929F9B4FD405482CE681D9E9297AF08F5469025;
IL2CPP_EXTERN_C String_t* _stringLiteralB2F9235F4F063A8609A1E74346AC3F275A7303EE;
IL2CPP_EXTERN_C String_t* _stringLiteralB5965463376BB283A639934AF66DD9F2A1A062AA;
IL2CPP_EXTERN_C String_t* _stringLiteralBD150095AD1723163A0791D57A71CFF29421A88E;
IL2CPP_EXTERN_C String_t* _stringLiteralC295AE7F3D676E2CAA3DE0DC641EF335E57A2E37;
IL2CPP_EXTERN_C String_t* _stringLiteralC2DA60AE96E2C9EF3EAF20897A5AA957AFDF64EC;
IL2CPP_EXTERN_C String_t* _stringLiteralC3EC0475D7BECB6F89847EE0E364B00D04507118;
IL2CPP_EXTERN_C String_t* _stringLiteralC4729ED69061AF5587EABEA577EE432AC85A94DB;
IL2CPP_EXTERN_C String_t* _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677;
IL2CPP_EXTERN_C String_t* _stringLiteralC6DE535D828F30C374EB3BE3FFDE520228FC3096;
IL2CPP_EXTERN_C String_t* _stringLiteralC8BD3DCAB0097617B6017163139B4704213A67EF;
IL2CPP_EXTERN_C String_t* _stringLiteralCD8C0871ADAE319947AA8BA890CC94E7926A9C70;
IL2CPP_EXTERN_C String_t* _stringLiteralD3992DF679A3EF8B96232992FF89A2B1F1DB5534;
IL2CPP_EXTERN_C String_t* _stringLiteralD3E1BCEB702885F4CBCAF83976FF64FEF7A55EE3;
IL2CPP_EXTERN_C String_t* _stringLiteralD5B20EA6805F285482807C61CD81D1509724E3CC;
IL2CPP_EXTERN_C String_t* _stringLiteralD744E0023ACB34526A1B142EFA90B5CFF45FDC53;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralDC4A06A0DE599F745DBDD44A6FDE6212859D3A5F;
IL2CPP_EXTERN_C String_t* _stringLiteralDE923A0A39342ECBAD1253F5A36CD36E9E72666D;
IL2CPP_EXTERN_C String_t* _stringLiteralE7D028CCE3B6E7B61AE2C752D7AE970DA04AB7C6;
IL2CPP_EXTERN_C String_t* _stringLiteralEAA0AD4C9DDC7B173ACD12710BBE084A3B32C5F6;
IL2CPP_EXTERN_C String_t* _stringLiteralF3C6C902DBF80139640F6554F0C3392016A8ADF7;
IL2CPP_EXTERN_C String_t* _stringLiteralFA3B5499785CBEEA66513CEE09402FBF10AF5FBF;
IL2CPP_EXTERN_C String_t* _stringLiteralFEA0D25AE1D3DDABAAE8CE7E329A0911AB161618;
IL2CPP_EXTERN_C const RuntimeMethod* AndroidJavaObject_GetStatic_TisString_t_mF408A1C0C6E5BF8154F00A450A97A51B2ABFCBDE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConfigManagerImpl_LoadFromCache_m308A9C3C2867E19A7348741D3BF09EBCAAE4D156_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConfigManagerImpl_SaveCache_m43661F9802E18D7B3BDE3E372AF46D72E08FB5E4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_m472ECA9A0B49BFD1553C6AFB1B926F2A9DC8E07B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_mCF1D722A2A472811B0A1D81205BD73AD064AFDC1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_get_Keys_m0A27AAFC34C1E6AC8FFA238F61151F2C22748599_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_m946DA5F7EED6E700A1D4B25A93897A1248ED5A70_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_Select_TisJProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4_TisString_t_m928103D228A7FFCA8F8751874BA290AB9FD067B3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_ToArray_TisString_t_mCD2BC789CBFF834E06F00948FC47E15E720936DC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m02ABAE8BB0E4A6356F33117FC781FB5E8F04C680_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m1DEFE09EF1D0A3CE3C51A4A06C471B5A272939FE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m62199928E4E61AF736738A346A85DC979AF27D2C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_m0CDA887E6760543D0ABE8722B4DE088D49F87F85_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_m203F36D1E99FED6FCC96C594AE5D5B70981FD140_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_m33E4BFC93CB232DD900322131149D15FF22FF12B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_m74F27D7302F75A8327373EC0A364AFC11ADD0E76_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_m7AA79A472AE62BDA8AE5DACD99FF84BEF4DE800E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_mC9EFE54C2C30BA46A2066277788398580C887257_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Extensions_Value_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m1DB6D797C74FDFDDAC6548EE8EA80DD90E9430A3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Extensions_Value_TisInt32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_m3092267C93448D476CE9F21D518B204704D234B8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Extensions_Value_TisInt64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_m6F4AADD3516AF69D3B4211A1CE328B7DE1F17145_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Extensions_Value_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_mC5F3E49729A00991AFA91AC1F88BD187279B96AE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Extensions_Value_TisString_t_m2497E7CEFECAA73AFA2AC29B672F29E6489E1D30_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* JToken_ToObject_TisConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_mDE14C69A8F47BC3C3D33A3EED6D30FB2314F9EDA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyCollection_GetEnumerator_m9CE20FA88F49E3AC89C3194787B1698BB7A0F700_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Key_m58D71AFA188B3B9B9C6FFE10C720DE49333F1A08_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Value_m2BC92622340FE4FDF5ECB521489A8AC781D8BA19_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_GetEnumerator_m3465F03E8555CE28FCA9069FE1CD237725DF45F2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_GetEnumerator_mA5F623247EAF5110C665A71C65BE424E21AC8798_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m5F52BEE935E79774B7BEB5DF51F0AA696A0598C6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mA28F18D77CFE93EBCAC6BD896325683999D261FD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_GetValueOrDefault_m7AFC352C983BBB73C8142843D7BA4ABBCDB8E67E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1__ctor_m52AD48CA918ECAA8E53A7DE5F83CA02AF3EA544B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_HasValue_m062422AAA723286DD6D3FDEA566B13560D01CEEE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec_U3CGetKeysU3Eb__30_0_m26AE8D3356D22C9291C1D6D154052615CD230AE5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass35_0_U3CDoRequestU3Eb__0_mF929AB208D7DBCBAEA4FFD588963D5090901A503_RuntimeMethod_var;
struct CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804_marshaled_com;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB_marshaled_com;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;
struct UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F_marshaled_com;
struct UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F_marshaled_pinvoke;
struct UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6_marshaled_com;

struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tBA73CDFA4C61E9CCD7F4619E31A682FBEE97B71D 
{
};

// System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.ConfigResponse>
struct Dictionary_2_t1350928D43387352EDB22C6979983B8129804127  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.Dictionary`2::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::_entries
	EntryU5BU5D_t6F91280F546B7A76A0B8019B0F6B78C75AA07FAB* ____entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::_count
	int32_t ____count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeList
	int32_t ____freeList_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeCount
	int32_t ____freeCount_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::_version
	int32_t ____version_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::_comparer
	RuntimeObject* ____comparer_6;
	// System.Collections.Generic.Dictionary`2/KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_keys
	KeyCollection_t0A9920E929E6DC22266AFBE84DE8CBED675E3E21* ____keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_values
	ValueCollection_t9C389C48BBCBE0D48B7470BA5A91403D84A8ADF2* ____values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject* ____syncRoot_9;
};

// System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.RuntimeConfig>
struct Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.Dictionary`2::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::_entries
	EntryU5BU5D_tED2BF2245A08F0596C0CECAE9FE4C67FCBCD8326* ____entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::_count
	int32_t ____count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeList
	int32_t ____freeList_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeCount
	int32_t ____freeCount_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::_version
	int32_t ____version_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::_comparer
	RuntimeObject* ____comparer_6;
	// System.Collections.Generic.Dictionary`2/KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_keys
	KeyCollection_tDABE6E934B2EF300EC234A664076A202E3BFA4BE* ____keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_values
	ValueCollection_tB260FA65D3210B4C8615A8D9030D916502A7E0C2* ____values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject* ____syncRoot_9;
};

// System.Collections.Generic.Dictionary`2<System.String,System.String>
struct Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.Dictionary`2::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::_entries
	EntryU5BU5D_t1AF33AD0B7330843448956EC4277517081658AE7* ____entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::_count
	int32_t ____count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeList
	int32_t ____freeList_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeCount
	int32_t ____freeCount_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::_version
	int32_t ____version_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::_comparer
	RuntimeObject* ____comparer_6;
	// System.Collections.Generic.Dictionary`2/KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_keys
	KeyCollection_t2EDD317F5771E575ACB63527B5AFB71291040342* ____keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_values
	ValueCollection_t238D0D2427C6B841A01F522A41540165A2C4AE76* ____values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject* ____syncRoot_9;
};

// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,Unity.RemoteConfig.RuntimeConfig>
struct KeyCollection_tDABE6E934B2EF300EC234A664076A202E3BFA4BE  : public RuntimeObject
{
	// System.Collections.Generic.Dictionary`2<TKey,TValue> System.Collections.Generic.Dictionary`2/KeyCollection::_dictionary
	Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* ____dictionary_0;
};

// System.Collections.Generic.List`1<System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>>
struct List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	Func_1U5BU5D_t35E715A5393234AC7F32707564384207E5B82905* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	Func_1U5BU5D_t35E715A5393234AC7F32707564384207E5B82905* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>>
struct List_1_t0829E916C4AAB917E57526AEED3AB682DB994946  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	Func_3U5BU5D_t350FFC71609BA6C4B7770BB3442A641932D33B03* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_t0829E916C4AAB917E57526AEED3AB682DB994946_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	Func_3U5BU5D_t350FFC71609BA6C4B7770BB3442A641932D33B03* ___s_emptyArray_5;
};

// UnityEngine.AndroidJavaObject
struct AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0  : public RuntimeObject
{
	// UnityEngine.GlobalJavaObjectRef UnityEngine.AndroidJavaObject::m_jobject
	GlobalJavaObjectRef_t20D8E5AAFC2EB2518FCABBF40465855E797FF0D8* ___m_jobject_1;
	// UnityEngine.GlobalJavaObjectRef UnityEngine.AndroidJavaObject::m_jclass
	GlobalJavaObjectRef_t20D8E5AAFC2EB2518FCABBF40465855E797FF0D8* ___m_jclass_2;
};

struct AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_StaticFields
{
	// System.Boolean UnityEngine.AndroidJavaObject::enableDebugPrints
	bool ___enableDebugPrints_0;
};
struct Il2CppArrayBounds;

// Unity.RemoteConfig.ConfigManager
struct ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171  : public RuntimeObject
{
};

struct ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields
{
	// Unity.RemoteConfig.ConfigManagerImpl Unity.RemoteConfig.ConfigManager::ConfigManagerImpl
	ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* ___ConfigManagerImpl_0;
};

// System.Text.Encoding
struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095  : public RuntimeObject
{
	// System.Int32 System.Text.Encoding::m_codePage
	int32_t ___m_codePage_9;
	// System.Globalization.CodePageDataItem System.Text.Encoding::dataItem
	CodePageDataItem_t52460FA30AE37F4F26ACB81055E58002262F19F2* ___dataItem_10;
	// System.Boolean System.Text.Encoding::m_deserializedFromEverett
	bool ___m_deserializedFromEverett_11;
	// System.Boolean System.Text.Encoding::m_isReadOnly
	bool ___m_isReadOnly_12;
	// System.Text.EncoderFallback System.Text.Encoding::encoderFallback
	EncoderFallback_tD2C40CE114AA9D8E1F7196608B2D088548015293* ___encoderFallback_13;
	// System.Text.DecoderFallback System.Text.Encoding::decoderFallback
	DecoderFallback_t7324102215E4ED41EC065C02EB501CB0BC23CD90* ___decoderFallback_14;
};

struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095_StaticFields
{
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::defaultEncoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___defaultEncoding_0;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::unicodeEncoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___unicodeEncoding_1;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::bigEndianUnicode
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___bigEndianUnicode_2;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf7Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___utf7Encoding_3;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf8Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___utf8Encoding_4;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf32Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___utf32Encoding_5;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::asciiEncoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___asciiEncoding_6;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::latin1Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___latin1Encoding_7;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Text.Encoding> modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::encodings
	Dictionary_2_t87EDE08B2E48F793A22DE50D6B3CC2E7EBB2DB54* ___encodings_8;
	// System.Object System.Text.Encoding::s_InternalSyncObject
	RuntimeObject* ___s_InternalSyncObject_15;
};

// Newtonsoft.Json.Linq.JToken
struct JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3  : public RuntimeObject
{
	// Newtonsoft.Json.Linq.JContainer Newtonsoft.Json.Linq.JToken::_parent
	JContainer_tFD3E2CD9B9D8D3CD73133B11A1F6BE77C5C8F95A* ____parent_1;
	// Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JToken::_previous
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* ____previous_2;
	// Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JToken::_next
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* ____next_3;
	// System.Object Newtonsoft.Json.Linq.JToken::_annotations
	RuntimeObject* ____annotations_4;
};

struct JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3_StaticFields
{
	// Newtonsoft.Json.Linq.JTokenEqualityComparer Newtonsoft.Json.Linq.JToken::_equalityComparer
	JTokenEqualityComparer_t2B7EB6B1D12A8C94152AB2E690CC45F185373C46* ____equalityComparer_0;
	// Newtonsoft.Json.Linq.JTokenType[] Newtonsoft.Json.Linq.JToken::BooleanTypes
	JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0* ___BooleanTypes_5;
	// Newtonsoft.Json.Linq.JTokenType[] Newtonsoft.Json.Linq.JToken::NumberTypes
	JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0* ___NumberTypes_6;
	// Newtonsoft.Json.Linq.JTokenType[] Newtonsoft.Json.Linq.JToken::BigIntegerTypes
	JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0* ___BigIntegerTypes_7;
	// Newtonsoft.Json.Linq.JTokenType[] Newtonsoft.Json.Linq.JToken::StringTypes
	JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0* ___StringTypes_8;
	// Newtonsoft.Json.Linq.JTokenType[] Newtonsoft.Json.Linq.JToken::GuidTypes
	JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0* ___GuidTypes_9;
	// Newtonsoft.Json.Linq.JTokenType[] Newtonsoft.Json.Linq.JToken::TimeSpanTypes
	JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0* ___TimeSpanTypes_10;
	// Newtonsoft.Json.Linq.JTokenType[] Newtonsoft.Json.Linq.JToken::UriTypes
	JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0* ___UriTypes_11;
	// Newtonsoft.Json.Linq.JTokenType[] Newtonsoft.Json.Linq.JToken::CharTypes
	JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0* ___CharTypes_12;
	// Newtonsoft.Json.Linq.JTokenType[] Newtonsoft.Json.Linq.JToken::DateTimeTypes
	JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0* ___DateTimeTypes_13;
	// Newtonsoft.Json.Linq.JTokenType[] Newtonsoft.Json.Linq.JToken::BytesTypes
	JTokenTypeU5BU5D_tDCF677D46AB555A7276A6A1795A099AA73056DA0* ___BytesTypes_14;
};

// System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE  : public RuntimeObject
{
	// System.Object System.MarshalByRefObject::_identity
	RuntimeObject* ____identity_0;
};
// Native definition for P/Invoke marshalling of System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_pinvoke
{
	Il2CppIUnknown* ____identity_0;
};
// Native definition for COM marshalling of System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_com
{
	Il2CppIUnknown* ____identity_0;
};

// Unity.RemoteConfig.RCUnityWebRequest
struct RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26  : public RuntimeObject
{
	// UnityEngine.Networking.UnityWebRequest Unity.RemoteConfig.RCUnityWebRequest::<_unityWebRequest>k__BackingField
	UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* ___U3C_unityWebRequestU3Ek__BackingField_0;
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// Unity.RemoteConfig.UnityAttributes
struct UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04  : public RuntimeObject
{
	// System.String Unity.RemoteConfig.UnityAttributes::osVersion
	String_t* ___osVersion_0;
	// System.String Unity.RemoteConfig.UnityAttributes::appVersion
	String_t* ___appVersion_1;
	// System.Boolean Unity.RemoteConfig.UnityAttributes::rootedJailbroken
	bool ___rootedJailbroken_2;
	// System.String Unity.RemoteConfig.UnityAttributes::model
	String_t* ___model_3;
	// System.String Unity.RemoteConfig.UnityAttributes::cpu
	String_t* ___cpu_4;
	// System.Int32 Unity.RemoteConfig.UnityAttributes::cpuCount
	int32_t ___cpuCount_5;
	// System.Int32 Unity.RemoteConfig.UnityAttributes::cpuFrequency
	int32_t ___cpuFrequency_6;
	// System.Int32 Unity.RemoteConfig.UnityAttributes::ram
	int32_t ___ram_7;
	// System.Int32 Unity.RemoteConfig.UnityAttributes::vram
	int32_t ___vram_8;
	// System.String Unity.RemoteConfig.UnityAttributes::screen
	String_t* ___screen_9;
	// System.Int32 Unity.RemoteConfig.UnityAttributes::dpi
	int32_t ___dpi_10;
	// System.String Unity.RemoteConfig.UnityAttributes::language
	String_t* ___language_11;
	// System.String Unity.RemoteConfig.UnityAttributes::appName
	String_t* ___appName_12;
	// System.String Unity.RemoteConfig.UnityAttributes::appInstallMode
	String_t* ___appInstallMode_13;
	// System.String Unity.RemoteConfig.UnityAttributes::appInstallStore
	String_t* ___appInstallStore_14;
	// System.Int32 Unity.RemoteConfig.UnityAttributes::graphicsDeviceId
	int32_t ___graphicsDeviceId_15;
	// System.Int32 Unity.RemoteConfig.UnityAttributes::graphicsDeviceVendorId
	int32_t ___graphicsDeviceVendorId_16;
	// System.String Unity.RemoteConfig.UnityAttributes::graphicsName
	String_t* ___graphicsName_17;
	// System.String Unity.RemoteConfig.UnityAttributes::graphicsDeviceVendor
	String_t* ___graphicsDeviceVendor_18;
	// System.String Unity.RemoteConfig.UnityAttributes::graphicsVersion
	String_t* ___graphicsVersion_19;
	// System.Int32 Unity.RemoteConfig.UnityAttributes::graphicsShader
	int32_t ___graphicsShader_20;
	// System.Int32 Unity.RemoteConfig.UnityAttributes::maxTextureSize
	int32_t ___maxTextureSize_21;
};

// System.Uri
struct Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E  : public RuntimeObject
{
	// System.String System.Uri::m_String
	String_t* ___m_String_16;
	// System.String System.Uri::m_originalUnicodeString
	String_t* ___m_originalUnicodeString_17;
	// System.UriParser System.Uri::m_Syntax
	UriParser_t920B0868286118827C08B08A15A9456AF6C19D81* ___m_Syntax_18;
	// System.String System.Uri::m_DnsSafeHost
	String_t* ___m_DnsSafeHost_19;
	// System.Uri/Flags System.Uri::m_Flags
	uint64_t ___m_Flags_20;
	// System.Uri/UriInfo System.Uri::m_Info
	UriInfo_t5F91F77A93545DDDA6BB24A609BAF5E232CC1A09* ___m_Info_21;
	// System.Boolean System.Uri::m_iriParsing
	bool ___m_iriParsing_22;
};

struct Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E_StaticFields
{
	// System.String System.Uri::UriSchemeFile
	String_t* ___UriSchemeFile_0;
	// System.String System.Uri::UriSchemeFtp
	String_t* ___UriSchemeFtp_1;
	// System.String System.Uri::UriSchemeGopher
	String_t* ___UriSchemeGopher_2;
	// System.String System.Uri::UriSchemeHttp
	String_t* ___UriSchemeHttp_3;
	// System.String System.Uri::UriSchemeHttps
	String_t* ___UriSchemeHttps_4;
	// System.String System.Uri::UriSchemeWs
	String_t* ___UriSchemeWs_5;
	// System.String System.Uri::UriSchemeWss
	String_t* ___UriSchemeWss_6;
	// System.String System.Uri::UriSchemeMailto
	String_t* ___UriSchemeMailto_7;
	// System.String System.Uri::UriSchemeNews
	String_t* ___UriSchemeNews_8;
	// System.String System.Uri::UriSchemeNntp
	String_t* ___UriSchemeNntp_9;
	// System.String System.Uri::UriSchemeNetTcp
	String_t* ___UriSchemeNetTcp_10;
	// System.String System.Uri::UriSchemeNetPipe
	String_t* ___UriSchemeNetPipe_11;
	// System.String System.Uri::SchemeDelimiter
	String_t* ___SchemeDelimiter_12;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_ConfigInitialized
	bool ___s_ConfigInitialized_23;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_ConfigInitializing
	bool ___s_ConfigInitializing_24;
	// System.UriIdnScope modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_IdnScope
	int32_t ___s_IdnScope_25;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_IriParsing
	bool ___s_IriParsing_26;
	// System.Boolean System.Uri::useDotNetRelativeOrAbsolute
	bool ___useDotNetRelativeOrAbsolute_27;
	// System.Boolean System.Uri::IsWindowsFileSystem
	bool ___IsWindowsFileSystem_29;
	// System.Object System.Uri::s_initLock
	RuntimeObject* ___s_initLock_30;
	// System.Char[] System.Uri::HexLowerChars
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___HexLowerChars_34;
	// System.Char[] System.Uri::_WSchars
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ____WSchars_35;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// UnityEngine.YieldInstruction
struct YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_com
{
};

// Unity.RemoteConfig.ConfigManagerImpl/<>c__DisplayClass35_0
struct U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548  : public RuntimeObject
{
	// Unity.RemoteConfig.ConfigManagerImpl Unity.RemoteConfig.ConfigManagerImpl/<>c__DisplayClass35_0::<>4__this
	ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* ___U3CU3E4__this_0;
	// System.String Unity.RemoteConfig.ConfigManagerImpl/<>c__DisplayClass35_0::configType
	String_t* ___configType_1;
	// Unity.RemoteConfig.RCUnityWebRequest Unity.RemoteConfig.ConfigManagerImpl/<>c__DisplayClass35_0::request
	RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* ___request_2;
};

// Unity.RemoteConfig.RuntimeConfig/<>c
struct U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9  : public RuntimeObject
{
};

struct U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_StaticFields
{
	// Unity.RemoteConfig.RuntimeConfig/<>c Unity.RemoteConfig.RuntimeConfig/<>c::<>9
	U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9* ___U3CU3E9_0;
	// System.Func`2<Newtonsoft.Json.Linq.JProperty,System.String> Unity.RemoteConfig.RuntimeConfig/<>c::<>9__30_0
	Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879* ___U3CU3E9__30_0_1;
};

// System.Collections.Generic.List`1/Enumerator<System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>>
struct Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8 
{
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::_list
	List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C* ____list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_version
	int32_t ____version_2;
	// T System.Collections.Generic.List`1/Enumerator::_current
	Func_1_t2A08DEC58BFB76B9DDF49BCF555A3342127229B5* ____current_3;
};

// System.Collections.Generic.List`1/Enumerator<System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>>
struct Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803 
{
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::_list
	List_1_t0829E916C4AAB917E57526AEED3AB682DB994946* ____list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_version
	int32_t ____version_2;
	// T System.Collections.Generic.List`1/Enumerator::_current
	Func_3_t6491300EDE89815C2EE58365B51E0AE133B267AD* ____current_3;
};

// System.Collections.Generic.List`1/Enumerator<System.Object>
struct Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A 
{
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::_list
	List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ____list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_version
	int32_t ____version_2;
	// T System.Collections.Generic.List`1/Enumerator::_current
	RuntimeObject* ____current_3;
};

// System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<System.Object,System.Object>
struct Enumerator_t65CC956745B1180C04CE6C6910FB27C5F32BB9FF 
{
	// System.Collections.Generic.Dictionary`2<TKey,TValue> System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator::_dictionary
	Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* ____dictionary_0;
	// System.Int32 System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator::_version
	int32_t ____version_2;
	// TKey System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator::_currentKey
	RuntimeObject* ____currentKey_3;
};

// System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<System.String,Unity.RemoteConfig.RuntimeConfig>
struct Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B 
{
	// System.Collections.Generic.Dictionary`2<TKey,TValue> System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator::_dictionary
	Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* ____dictionary_0;
	// System.Int32 System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator::_version
	int32_t ____version_2;
	// TKey System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator::_currentKey
	String_t* ____currentKey_3;
};

// System.Collections.Generic.KeyValuePair`2<System.Object,System.Object>
struct KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 
{
	// TKey System.Collections.Generic.KeyValuePair`2::key
	RuntimeObject* ___key_0;
	// TValue System.Collections.Generic.KeyValuePair`2::value
	RuntimeObject* ___value_1;
};

// System.Collections.Generic.KeyValuePair`2<System.String,Newtonsoft.Json.Linq.JToken>
struct KeyValuePair_2_t25BF56B44F40AC19698F68DD29593E307D428F8B 
{
	// TKey System.Collections.Generic.KeyValuePair`2::key
	String_t* ___key_0;
	// TValue System.Collections.Generic.KeyValuePair`2::value
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* ___value_1;
};

// Unity.Collections.NativeArray`1<System.Byte>
struct NativeArray_1_t81F55263465517B73C455D3400CF67B4BADD85CF 
{
	// System.Void* Unity.Collections.NativeArray`1::m_Buffer
	void* ___m_Buffer_0;
	// System.Int32 Unity.Collections.NativeArray`1::m_Length
	int32_t ___m_Length_1;
	// Unity.Collections.Allocator Unity.Collections.NativeArray`1::m_AllocatorLabel
	int32_t ___m_AllocatorLabel_2;
};

// System.Nullable`1<System.Boolean>
struct Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	bool ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.ConstructorHandling>
struct Nullable_1_tE866C25CB8A73A44077AAC48B1D406CF034E1496 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.DateFormatHandling>
struct Nullable_1_t4776B8A4D0D52AA8BDCD45E6D7070659326453D2 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.DateParseHandling>
struct Nullable_1_tDC640D18A54CA8F0A3C74518CBC15D439C8FC228 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.DateTimeZoneHandling>
struct Nullable_1_tD88F7E37B65824D38D74608E576D1265E5A2D2B2 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.DefaultValueHandling>
struct Nullable_1_t4DEE77C12DDAF72BAE2A1FA8A8736FC478D721E8 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.FloatFormatHandling>
struct Nullable_1_tEAE8D5B59DCEB4F809A8A5F390EAAC18F266B822 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.FloatParseHandling>
struct Nullable_1_tC13211A32645AE3863530378A08BC45089EE419B 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.Formatting>
struct Nullable_1_tAEE2B9C53750E53F9B91B70967290720873E8D3E 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<System.Int32>
struct Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<System.Int32Enum>
struct Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.Linq.JTokenType>
struct Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.MetadataPropertyHandling>
struct Nullable_1_t0E2AF35997B80CE423EBCAFDC0C58FB7182CA6FE 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.MissingMemberHandling>
struct Nullable_1_t776B72BEFF6E3E2D489C4C6D855C89139D6B4CA4 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.NullValueHandling>
struct Nullable_1_tA1B6210C1924173AEFE9AF8FBDD3BA856E74A790 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.ObjectCreationHandling>
struct Nullable_1_t5ECEC9E2B3F1C050A3E9EC928487DD5C9AB0996D 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.PreserveReferencesHandling>
struct Nullable_1_t599FF2F862BEFE0F4B6BDA65B36841F4740B0D12 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.ReferenceLoopHandling>
struct Nullable_1_t599F8D9D40143BFCB12D7085DFEA8AC7171F5E77 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.StringEscapeHandling>
struct Nullable_1_t61214A44C233A0B00A9F79E380485D79D5FAA7C6 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.TypeNameAssemblyFormatHandling>
struct Nullable_1_t762E380C63D6C0CB1E8ADBCADE57240FB061367F 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<Newtonsoft.Json.TypeNameHandling>
struct Nullable_1_tB85AB604017196E6A3D3B920121E8C3A255827F0 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// UnityEngine.AndroidJavaClass
struct AndroidJavaClass_tE6296B30CC4BF84434A9B765267F3FD0DD8DDB03  : public AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0
{
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Byte
struct Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3 
{
	// System.Byte System.Byte::m_value
	uint8_t ___m_value_0;
};

// Unity.RemoteConfig.ConfigResponse
struct ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 
{
	// Unity.RemoteConfig.ConfigOrigin Unity.RemoteConfig.ConfigResponse::requestOrigin
	int32_t ___requestOrigin_0;
	// Unity.RemoteConfig.ConfigRequestStatus Unity.RemoteConfig.ConfigResponse::status
	int32_t ___status_1;
	// Newtonsoft.Json.Linq.JObject Unity.RemoteConfig.ConfigResponse::body
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* ___body_2;
	// System.Collections.Generic.Dictionary`2<System.String,System.String> Unity.RemoteConfig.ConfigResponse::headers
	Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___headers_3;
};
// Native definition for P/Invoke marshalling of Unity.RemoteConfig.ConfigResponse
struct ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshaled_pinvoke
{
	int32_t ___requestOrigin_0;
	int32_t ___status_1;
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* ___body_2;
	Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___headers_3;
};
// Native definition for COM marshalling of Unity.RemoteConfig.ConfigResponse
struct ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshaled_com
{
	int32_t ___requestOrigin_0;
	int32_t ___status_1;
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* ___body_2;
	Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___headers_3;
};

// System.DateTime
struct DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D 
{
	// System.UInt64 System.DateTime::_dateData
	uint64_t ____dateData_46;
};

struct DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D_StaticFields
{
	// System.Int32[] System.DateTime::s_daysToMonth365
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___s_daysToMonth365_30;
	// System.Int32[] System.DateTime::s_daysToMonth366
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___s_daysToMonth366_31;
	// System.DateTime System.DateTime::MinValue
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ___MinValue_32;
	// System.DateTime System.DateTime::MaxValue
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ___MaxValue_33;
	// System.DateTime System.DateTime::UnixEpoch
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ___UnixEpoch_34;
};

// System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2  : public ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F
{
};

struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_StaticFields
{
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___enumSeperatorCharArray_0;
};
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_com
{
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.Int64
struct Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3 
{
	// System.Int64 System.Int64::m_value
	int64_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// Newtonsoft.Json.Linq.JContainer
struct JContainer_tFD3E2CD9B9D8D3CD73133B11A1F6BE77C5C8F95A  : public JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3
{
	// System.ComponentModel.ListChangedEventHandler Newtonsoft.Json.Linq.JContainer::_listChanged
	ListChangedEventHandler_tDBF36F3E2C6B7538106878E1D5A7553C5EA77616* ____listChanged_15;
	// System.ComponentModel.AddingNewEventHandler Newtonsoft.Json.Linq.JContainer::_addingNew
	AddingNewEventHandler_tD9BAC60F604446ED14967643F63A83CE2A5C3701* ____addingNew_16;
	// System.Collections.Specialized.NotifyCollectionChangedEventHandler Newtonsoft.Json.Linq.JContainer::_collectionChanged
	NotifyCollectionChangedEventHandler_t521FADBD1190F88022BC2160A5F82FDFC08364AF* ____collectionChanged_17;
	// System.Object Newtonsoft.Json.Linq.JContainer::_syncRoot
	RuntimeObject* ____syncRoot_18;
	// System.Boolean Newtonsoft.Json.Linq.JContainer::_busy
	bool ____busy_19;
};

// Unity.RemoteConfig.RemoteConfigRequest
struct RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815 
{
	// System.String Unity.RemoteConfig.RemoteConfigRequest::projectId
	String_t* ___projectId_0;
	// System.String Unity.RemoteConfig.RemoteConfigRequest::userId
	String_t* ___userId_1;
	// System.Boolean Unity.RemoteConfig.RemoteConfigRequest::isDebugBuild
	bool ___isDebugBuild_2;
	// System.String Unity.RemoteConfig.RemoteConfigRequest::configType
	String_t* ___configType_3;
	// System.String[] Unity.RemoteConfig.RemoteConfigRequest::key
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___key_4;
	// System.String[] Unity.RemoteConfig.RemoteConfigRequest::type
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___type_5;
	// System.String[] Unity.RemoteConfig.RemoteConfigRequest::schemaId
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___schemaId_6;
	// System.String Unity.RemoteConfig.RemoteConfigRequest::customUserId
	String_t* ___customUserId_7;
	// System.String Unity.RemoteConfig.RemoteConfigRequest::environmentId
	String_t* ___environmentId_8;
	// System.String Unity.RemoteConfig.RemoteConfigRequest::packageVersion
	String_t* ___packageVersion_9;
	// System.String Unity.RemoteConfig.RemoteConfigRequest::originService
	String_t* ___originService_10;
	// Newtonsoft.Json.Linq.JObject Unity.RemoteConfig.RemoteConfigRequest::attributionMetadata
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* ___attributionMetadata_11;
};
// Native definition for P/Invoke marshalling of Unity.RemoteConfig.RemoteConfigRequest
struct RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshaled_pinvoke
{
	char* ___projectId_0;
	char* ___userId_1;
	int32_t ___isDebugBuild_2;
	char* ___configType_3;
	char** ___key_4;
	char** ___type_5;
	char** ___schemaId_6;
	char* ___customUserId_7;
	char* ___environmentId_8;
	char* ___packageVersion_9;
	char* ___originService_10;
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* ___attributionMetadata_11;
};
// Native definition for COM marshalling of Unity.RemoteConfig.RemoteConfigRequest
struct RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshaled_com
{
	Il2CppChar* ___projectId_0;
	Il2CppChar* ___userId_1;
	int32_t ___isDebugBuild_2;
	Il2CppChar* ___configType_3;
	Il2CppChar** ___key_4;
	Il2CppChar** ___type_5;
	Il2CppChar** ___schemaId_6;
	Il2CppChar* ___customUserId_7;
	Il2CppChar* ___environmentId_8;
	Il2CppChar* ___packageVersion_9;
	Il2CppChar* ___originService_10;
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* ___attributionMetadata_11;
};

// Unity.RemoteConfig.RequestHeaderTuple
struct RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964 
{
	// System.String Unity.RemoteConfig.RequestHeaderTuple::key
	String_t* ___key_0;
	// System.String Unity.RemoteConfig.RequestHeaderTuple::value
	String_t* ___value_1;
};
// Native definition for P/Invoke marshalling of Unity.RemoteConfig.RequestHeaderTuple
struct RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshaled_pinvoke
{
	char* ___key_0;
	char* ___value_1;
};
// Native definition for COM marshalling of Unity.RemoteConfig.RequestHeaderTuple
struct RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshaled_com
{
	Il2CppChar* ___key_0;
	Il2CppChar* ___value_1;
};

// UnityEngine.Resolution
struct Resolution_tDF215F567EEFFD07B9A8FB7CEACC08EA6B8B9525 
{
	// System.Int32 UnityEngine.Resolution::m_Width
	int32_t ___m_Width_0;
	// System.Int32 UnityEngine.Resolution::m_Height
	int32_t ___m_Height_1;
	// System.Int32 UnityEngine.Resolution::m_RefreshRate
	int32_t ___m_RefreshRate_2;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// System.IO.Stream
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// System.IO.Stream/ReadWriteTask System.IO.Stream::_activeReadWriteTask
	ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05* ____activeReadWriteTask_2;
	// System.Threading.SemaphoreSlim System.IO.Stream::_asyncActiveSemaphore
	SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2* ____asyncActiveSemaphore_3;
};

struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE_StaticFields
{
	// System.IO.Stream System.IO.Stream::Null
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___Null_1;
};

// System.Runtime.Serialization.StreamingContext
struct StreamingContext_t56760522A751890146EE45F82F866B55B7E33677 
{
	// System.Object System.Runtime.Serialization.StreamingContext::m_additionalContext
	RuntimeObject* ___m_additionalContext_0;
	// System.Runtime.Serialization.StreamingContextStates System.Runtime.Serialization.StreamingContext::m_state
	int32_t ___m_state_1;
};
// Native definition for P/Invoke marshalling of System.Runtime.Serialization.StreamingContext
struct StreamingContext_t56760522A751890146EE45F82F866B55B7E33677_marshaled_pinvoke
{
	Il2CppIUnknown* ___m_additionalContext_0;
	int32_t ___m_state_1;
};
// Native definition for COM marshalling of System.Runtime.Serialization.StreamingContext
struct StreamingContext_t56760522A751890146EE45F82F866B55B7E33677_marshaled_com
{
	Il2CppIUnknown* ___m_additionalContext_0;
	int32_t ___m_state_1;
};

// System.IO.TextWriter
struct TextWriter_tA9E5461506CF806E17B6BBBF2119359DEDA3F0F3  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// System.Char[] System.IO.TextWriter::CoreNewLine
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___CoreNewLine_3;
	// System.String System.IO.TextWriter::CoreNewLineStr
	String_t* ___CoreNewLineStr_4;
	// System.IFormatProvider System.IO.TextWriter::_internalFormatProvider
	RuntimeObject* ____internalFormatProvider_5;
};

struct TextWriter_tA9E5461506CF806E17B6BBBF2119359DEDA3F0F3_StaticFields
{
	// System.IO.TextWriter System.IO.TextWriter::Null
	TextWriter_tA9E5461506CF806E17B6BBBF2119359DEDA3F0F3* ___Null_1;
	// System.Char[] System.IO.TextWriter::s_coreNewLine
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___s_coreNewLine_2;
};

// System.UInt64
struct UInt64_t8F12534CC8FC4B5860F2A2CD1EE79D322E7A41AF 
{
	// System.UInt64 System.UInt64::m_value
	uint64_t ___m_value_0;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// System.Nullable`1<System.Runtime.Serialization.StreamingContext>
struct Nullable_1_tC3E8E254B9DCF808C08AFA1FC2151C2BC0040F3A 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	StreamingContext_t56760522A751890146EE45F82F866B55B7E33677 ___value_1;
};

// UnityEngine.AsyncOperation
struct AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C  : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D
{
	// System.IntPtr UnityEngine.AsyncOperation::m_Ptr
	intptr_t ___m_Ptr_0;
	// System.Action`1<UnityEngine.AsyncOperation> UnityEngine.AsyncOperation::m_completeCallback
	Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB* ___m_completeCallback_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.AsyncOperation
struct AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C_marshaled_pinvoke : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
	Il2CppMethodPointer ___m_completeCallback_1;
};
// Native definition for COM marshalling of UnityEngine.AsyncOperation
struct AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C_marshaled_com : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_com
{
	intptr_t ___m_Ptr_0;
	Il2CppMethodPointer ___m_completeCallback_1;
};

// UnityEngine.Networking.CertificateHandler
struct CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Networking.CertificateHandler::m_Ptr
	intptr_t ___m_Ptr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Networking.CertificateHandler
struct CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.Networking.CertificateHandler
struct CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// Unity.RemoteConfig.ConfigManagerImpl
struct ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7  : public RuntimeObject
{
	// System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.RuntimeConfig> Unity.RemoteConfig.ConfigManagerImpl::configs
	Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* ___configs_2;
	// System.String Unity.RemoteConfig.ConfigManagerImpl::_playerIdentityToken
	String_t* ____playerIdentityToken_3;
	// Unity.RemoteConfig.RemoteConfigRequest Unity.RemoteConfig.ConfigManagerImpl::_remoteConfigRequest
	RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815 ____remoteConfigRequest_4;
	// Unity.RemoteConfig.UnityAttributes Unity.RemoteConfig.ConfigManagerImpl::_unityAttributes
	UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04* ____unityAttributes_5;
	// System.Collections.Generic.List`1<System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>> Unity.RemoteConfig.ConfigManagerImpl::requestHeaderProviders
	List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C* ___requestHeaderProviders_6;
	// System.Collections.Generic.List`1<System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>> Unity.RemoteConfig.ConfigManagerImpl::rawResponseValidators
	List_1_t0829E916C4AAB917E57526AEED3AB682DB994946* ___rawResponseValidators_7;
	// System.String Unity.RemoteConfig.ConfigManagerImpl::cacheFile
	String_t* ___cacheFile_8;
	// System.String Unity.RemoteConfig.ConfigManagerImpl::originService
	String_t* ___originService_9;
	// System.String Unity.RemoteConfig.ConfigManagerImpl::attributionMetadataStr
	String_t* ___attributionMetadataStr_10;
	// System.Action`1<Unity.RemoteConfig.ConfigResponse> Unity.RemoteConfig.ConfigManagerImpl::FetchCompleted
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___FetchCompleted_13;
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// UnityEngine.Networking.DownloadHandler
struct DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Networking.DownloadHandler::m_Ptr
	intptr_t ___m_Ptr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Networking.DownloadHandler
struct DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.Networking.DownloadHandler
struct DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t* ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject* ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject* ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips_15;
	// System.Int32 System.Exception::caught_in_unmanaged
	int32_t ___caught_in_unmanaged_16;
};

struct Exception_t_StaticFields
{
	// System.Object System.Exception::s_EDILock
	RuntimeObject* ___s_EDILock_0;
};
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};

// System.IO.FileStream
struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8  : public Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE
{
	// System.Byte[] System.IO.FileStream::buf
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buf_6;
	// System.String System.IO.FileStream::name
	String_t* ___name_7;
	// Microsoft.Win32.SafeHandles.SafeFileHandle System.IO.FileStream::safeHandle
	SafeFileHandle_t033FA6AAAC65F4BB25F4CBA9A242A58C95CD406E* ___safeHandle_8;
	// System.Boolean System.IO.FileStream::isExposed
	bool ___isExposed_9;
	// System.Int64 System.IO.FileStream::append_startpos
	int64_t ___append_startpos_10;
	// System.IO.FileAccess System.IO.FileStream::access
	int32_t ___access_11;
	// System.Boolean System.IO.FileStream::owner
	bool ___owner_12;
	// System.Boolean System.IO.FileStream::async
	bool ___async_13;
	// System.Boolean System.IO.FileStream::canseek
	bool ___canseek_14;
	// System.Boolean System.IO.FileStream::anonymous
	bool ___anonymous_15;
	// System.Boolean System.IO.FileStream::buf_dirty
	bool ___buf_dirty_16;
	// System.Int32 System.IO.FileStream::buf_size
	int32_t ___buf_size_17;
	// System.Int32 System.IO.FileStream::buf_length
	int32_t ___buf_length_18;
	// System.Int32 System.IO.FileStream::buf_offset
	int32_t ___buf_offset_19;
	// System.Int64 System.IO.FileStream::buf_start
	int64_t ___buf_start_20;
};

struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_StaticFields
{
	// System.Byte[] System.IO.FileStream::buf_recycle
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buf_recycle_4;
	// System.Object System.IO.FileStream::buf_recycle_lock
	RuntimeObject* ___buf_recycle_lock_5;
};

// Newtonsoft.Json.Linq.JObject
struct JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1  : public JContainer_tFD3E2CD9B9D8D3CD73133B11A1F6BE77C5C8F95A
{
	// Newtonsoft.Json.Linq.JPropertyKeyedCollection Newtonsoft.Json.Linq.JObject::_properties
	JPropertyKeyedCollection_t4A44691A9942B8A7AEB4016F7405BF388D1E0632* ____properties_20;
	// System.ComponentModel.PropertyChangedEventHandler Newtonsoft.Json.Linq.JObject::PropertyChanged
	PropertyChangedEventHandler_tF1250C146BE6FB43477D29C5D18A10B6329419DA* ___PropertyChanged_21;
	// System.ComponentModel.PropertyChangingEventHandler Newtonsoft.Json.Linq.JObject::PropertyChanging
	PropertyChangingEventHandler_tF293724DEA588C35A7E94C4F4413AEE6438FE9CD* ___PropertyChanging_22;
};

// Newtonsoft.Json.Linq.JProperty
struct JProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4  : public JContainer_tFD3E2CD9B9D8D3CD73133B11A1F6BE77C5C8F95A
{
	// Newtonsoft.Json.Linq.JProperty/JPropertyList Newtonsoft.Json.Linq.JProperty::_content
	JPropertyList_t53D97F8AB016B10A00D616C620766D38449D8C98* ____content_20;
	// System.String Newtonsoft.Json.Linq.JProperty::_name
	String_t* ____name_21;
};

// Unity.RemoteConfig.RuntimeConfig
struct RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99  : public RuntimeObject
{
	// Unity.RemoteConfig.ConfigOrigin Unity.RemoteConfig.RuntimeConfig::<origin>k__BackingField
	int32_t ___U3CoriginU3Ek__BackingField_0;
	// System.String Unity.RemoteConfig.RuntimeConfig::<environmentId>k__BackingField
	String_t* ___U3CenvironmentIdU3Ek__BackingField_1;
	// System.String Unity.RemoteConfig.RuntimeConfig::<assignmentId>k__BackingField
	String_t* ___U3CassignmentIdU3Ek__BackingField_2;
	// System.String Unity.RemoteConfig.RuntimeConfig::configType
	String_t* ___configType_3;
	// Unity.RemoteConfig.ConfigResponse Unity.RemoteConfig.RuntimeConfig::ConfigResponse
	ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___ConfigResponse_4;
	// Unity.RemoteConfig.ConfigRequestStatus Unity.RemoteConfig.RuntimeConfig::RequestStatus
	int32_t ___RequestStatus_5;
	// Newtonsoft.Json.Linq.JObject Unity.RemoteConfig.RuntimeConfig::_config
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* ____config_6;
	// Newtonsoft.Json.JsonSerializerSettings Unity.RemoteConfig.RuntimeConfig::rawDateSettings
	JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF* ___rawDateSettings_7;
	// System.Action`1<Unity.RemoteConfig.ConfigResponse> Unity.RemoteConfig.RuntimeConfig::FetchCompleted
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___FetchCompleted_8;
};

// System.IO.StreamWriter
struct StreamWriter_t6E7DF7D524AA3C018A65F62EE80779873ED4D1E4  : public TextWriter_tA9E5461506CF806E17B6BBBF2119359DEDA3F0F3
{
	// System.IO.Stream System.IO.StreamWriter::_stream
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ____stream_7;
	// System.Text.Encoding System.IO.StreamWriter::_encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ____encoding_8;
	// System.Text.Encoder System.IO.StreamWriter::_encoder
	Encoder_tAF9067231A76315584BDF4CD27990E2F485A78FA* ____encoder_9;
	// System.Byte[] System.IO.StreamWriter::_byteBuffer
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ____byteBuffer_10;
	// System.Char[] System.IO.StreamWriter::_charBuffer
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ____charBuffer_11;
	// System.Int32 System.IO.StreamWriter::_charPos
	int32_t ____charPos_12;
	// System.Int32 System.IO.StreamWriter::_charLen
	int32_t ____charLen_13;
	// System.Boolean System.IO.StreamWriter::_autoFlush
	bool ____autoFlush_14;
	// System.Boolean System.IO.StreamWriter::_haveWrittenPreamble
	bool ____haveWrittenPreamble_15;
	// System.Boolean System.IO.StreamWriter::_closable
	bool ____closable_16;
	// System.Threading.Tasks.Task System.IO.StreamWriter::_asyncWriteTask
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ____asyncWriteTask_17;
};

struct StreamWriter_t6E7DF7D524AA3C018A65F62EE80779873ED4D1E4_StaticFields
{
	// System.IO.StreamWriter System.IO.StreamWriter::Null
	StreamWriter_t6E7DF7D524AA3C018A65F62EE80779873ED4D1E4* ___Null_6;
};

// UnityEngine.Networking.UploadHandler
struct UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Networking.UploadHandler::m_Ptr
	intptr_t ___m_Ptr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Networking.UploadHandler
struct UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.Networking.UploadHandler
struct UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// UnityEngine.Networking.DownloadHandlerBuffer
struct DownloadHandlerBuffer_t34C626F6513FA9A44FDDDEE85455CF2CD9DA5974  : public DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB
{
	// Unity.Collections.NativeArray`1<System.Byte> UnityEngine.Networking.DownloadHandlerBuffer::m_NativeData
	NativeArray_1_t81F55263465517B73C455D3400CF67B4BADD85CF ___m_NativeData_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Networking.DownloadHandlerBuffer
struct DownloadHandlerBuffer_t34C626F6513FA9A44FDDDEE85455CF2CD9DA5974_marshaled_pinvoke : public DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB_marshaled_pinvoke
{
	NativeArray_1_t81F55263465517B73C455D3400CF67B4BADD85CF ___m_NativeData_1;
};
// Native definition for COM marshalling of UnityEngine.Networking.DownloadHandlerBuffer
struct DownloadHandlerBuffer_t34C626F6513FA9A44FDDDEE85455CF2CD9DA5974_marshaled_com : public DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB_marshaled_com
{
	NativeArray_1_t81F55263465517B73C455D3400CF67B4BADD85CF ___m_NativeData_1;
};

// Newtonsoft.Json.JsonSerializerSettings
struct JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF  : public RuntimeObject
{
	// System.Nullable`1<Newtonsoft.Json.Formatting> Newtonsoft.Json.JsonSerializerSettings::_formatting
	Nullable_1_tAEE2B9C53750E53F9B91B70967290720873E8D3E ____formatting_22;
	// System.Nullable`1<Newtonsoft.Json.DateFormatHandling> Newtonsoft.Json.JsonSerializerSettings::_dateFormatHandling
	Nullable_1_t4776B8A4D0D52AA8BDCD45E6D7070659326453D2 ____dateFormatHandling_23;
	// System.Nullable`1<Newtonsoft.Json.DateTimeZoneHandling> Newtonsoft.Json.JsonSerializerSettings::_dateTimeZoneHandling
	Nullable_1_tD88F7E37B65824D38D74608E576D1265E5A2D2B2 ____dateTimeZoneHandling_24;
	// System.Nullable`1<Newtonsoft.Json.DateParseHandling> Newtonsoft.Json.JsonSerializerSettings::_dateParseHandling
	Nullable_1_tDC640D18A54CA8F0A3C74518CBC15D439C8FC228 ____dateParseHandling_25;
	// System.Nullable`1<Newtonsoft.Json.FloatFormatHandling> Newtonsoft.Json.JsonSerializerSettings::_floatFormatHandling
	Nullable_1_tEAE8D5B59DCEB4F809A8A5F390EAAC18F266B822 ____floatFormatHandling_26;
	// System.Nullable`1<Newtonsoft.Json.FloatParseHandling> Newtonsoft.Json.JsonSerializerSettings::_floatParseHandling
	Nullable_1_tC13211A32645AE3863530378A08BC45089EE419B ____floatParseHandling_27;
	// System.Nullable`1<Newtonsoft.Json.StringEscapeHandling> Newtonsoft.Json.JsonSerializerSettings::_stringEscapeHandling
	Nullable_1_t61214A44C233A0B00A9F79E380485D79D5FAA7C6 ____stringEscapeHandling_28;
	// System.Globalization.CultureInfo Newtonsoft.Json.JsonSerializerSettings::_culture
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* ____culture_29;
	// System.Nullable`1<System.Boolean> Newtonsoft.Json.JsonSerializerSettings::_checkAdditionalContent
	Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01 ____checkAdditionalContent_30;
	// System.Nullable`1<System.Int32> Newtonsoft.Json.JsonSerializerSettings::_maxDepth
	Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28 ____maxDepth_31;
	// System.Boolean Newtonsoft.Json.JsonSerializerSettings::_maxDepthSet
	bool ____maxDepthSet_32;
	// System.String Newtonsoft.Json.JsonSerializerSettings::_dateFormatString
	String_t* ____dateFormatString_33;
	// System.Boolean Newtonsoft.Json.JsonSerializerSettings::_dateFormatStringSet
	bool ____dateFormatStringSet_34;
	// System.Nullable`1<Newtonsoft.Json.TypeNameAssemblyFormatHandling> Newtonsoft.Json.JsonSerializerSettings::_typeNameAssemblyFormatHandling
	Nullable_1_t762E380C63D6C0CB1E8ADBCADE57240FB061367F ____typeNameAssemblyFormatHandling_35;
	// System.Nullable`1<Newtonsoft.Json.DefaultValueHandling> Newtonsoft.Json.JsonSerializerSettings::_defaultValueHandling
	Nullable_1_t4DEE77C12DDAF72BAE2A1FA8A8736FC478D721E8 ____defaultValueHandling_36;
	// System.Nullable`1<Newtonsoft.Json.PreserveReferencesHandling> Newtonsoft.Json.JsonSerializerSettings::_preserveReferencesHandling
	Nullable_1_t599FF2F862BEFE0F4B6BDA65B36841F4740B0D12 ____preserveReferencesHandling_37;
	// System.Nullable`1<Newtonsoft.Json.NullValueHandling> Newtonsoft.Json.JsonSerializerSettings::_nullValueHandling
	Nullable_1_tA1B6210C1924173AEFE9AF8FBDD3BA856E74A790 ____nullValueHandling_38;
	// System.Nullable`1<Newtonsoft.Json.ObjectCreationHandling> Newtonsoft.Json.JsonSerializerSettings::_objectCreationHandling
	Nullable_1_t5ECEC9E2B3F1C050A3E9EC928487DD5C9AB0996D ____objectCreationHandling_39;
	// System.Nullable`1<Newtonsoft.Json.MissingMemberHandling> Newtonsoft.Json.JsonSerializerSettings::_missingMemberHandling
	Nullable_1_t776B72BEFF6E3E2D489C4C6D855C89139D6B4CA4 ____missingMemberHandling_40;
	// System.Nullable`1<Newtonsoft.Json.ReferenceLoopHandling> Newtonsoft.Json.JsonSerializerSettings::_referenceLoopHandling
	Nullable_1_t599F8D9D40143BFCB12D7085DFEA8AC7171F5E77 ____referenceLoopHandling_41;
	// System.Nullable`1<System.Runtime.Serialization.StreamingContext> Newtonsoft.Json.JsonSerializerSettings::_context
	Nullable_1_tC3E8E254B9DCF808C08AFA1FC2151C2BC0040F3A ____context_42;
	// System.Nullable`1<Newtonsoft.Json.ConstructorHandling> Newtonsoft.Json.JsonSerializerSettings::_constructorHandling
	Nullable_1_tE866C25CB8A73A44077AAC48B1D406CF034E1496 ____constructorHandling_43;
	// System.Nullable`1<Newtonsoft.Json.TypeNameHandling> Newtonsoft.Json.JsonSerializerSettings::_typeNameHandling
	Nullable_1_tB85AB604017196E6A3D3B920121E8C3A255827F0 ____typeNameHandling_44;
	// System.Nullable`1<Newtonsoft.Json.MetadataPropertyHandling> Newtonsoft.Json.JsonSerializerSettings::_metadataPropertyHandling
	Nullable_1_t0E2AF35997B80CE423EBCAFDC0C58FB7182CA6FE ____metadataPropertyHandling_45;
	// System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter> Newtonsoft.Json.JsonSerializerSettings::<Converters>k__BackingField
	RuntimeObject* ___U3CConvertersU3Ek__BackingField_46;
	// Newtonsoft.Json.Serialization.IContractResolver Newtonsoft.Json.JsonSerializerSettings::<ContractResolver>k__BackingField
	RuntimeObject* ___U3CContractResolverU3Ek__BackingField_47;
	// System.Collections.IEqualityComparer Newtonsoft.Json.JsonSerializerSettings::<EqualityComparer>k__BackingField
	RuntimeObject* ___U3CEqualityComparerU3Ek__BackingField_48;
	// System.Func`1<Newtonsoft.Json.Serialization.IReferenceResolver> Newtonsoft.Json.JsonSerializerSettings::<ReferenceResolverProvider>k__BackingField
	Func_1_t78E8B13F3C7D6CC3EB821B4F5D26999D062417E2* ___U3CReferenceResolverProviderU3Ek__BackingField_49;
	// Newtonsoft.Json.Serialization.ITraceWriter Newtonsoft.Json.JsonSerializerSettings::<TraceWriter>k__BackingField
	RuntimeObject* ___U3CTraceWriterU3Ek__BackingField_50;
	// Newtonsoft.Json.Serialization.ISerializationBinder Newtonsoft.Json.JsonSerializerSettings::<SerializationBinder>k__BackingField
	RuntimeObject* ___U3CSerializationBinderU3Ek__BackingField_51;
	// System.EventHandler`1<Newtonsoft.Json.Serialization.ErrorEventArgs> Newtonsoft.Json.JsonSerializerSettings::<Error>k__BackingField
	EventHandler_1_t69462DFC2F2C8D7576BEE9D1F5BB6C2E55B2C380* ___U3CErrorU3Ek__BackingField_52;
};

struct JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF_StaticFields
{
	// System.Runtime.Serialization.StreamingContext Newtonsoft.Json.JsonSerializerSettings::DefaultContext
	StreamingContext_t56760522A751890146EE45F82F866B55B7E33677 ___DefaultContext_9;
	// System.Globalization.CultureInfo Newtonsoft.Json.JsonSerializerSettings::DefaultCulture
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* ___DefaultCulture_18;
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// UnityEngine.Networking.UnityWebRequest
struct UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Networking.UnityWebRequest::m_Ptr
	intptr_t ___m_Ptr_0;
	// UnityEngine.Networking.DownloadHandler UnityEngine.Networking.UnityWebRequest::m_DownloadHandler
	DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* ___m_DownloadHandler_1;
	// UnityEngine.Networking.UploadHandler UnityEngine.Networking.UnityWebRequest::m_UploadHandler
	UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6* ___m_UploadHandler_2;
	// UnityEngine.Networking.CertificateHandler UnityEngine.Networking.UnityWebRequest::m_CertificateHandler
	CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804* ___m_CertificateHandler_3;
	// System.Uri UnityEngine.Networking.UnityWebRequest::m_Uri
	Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E* ___m_Uri_4;
	// System.Boolean UnityEngine.Networking.UnityWebRequest::<disposeCertificateHandlerOnDispose>k__BackingField
	bool ___U3CdisposeCertificateHandlerOnDisposeU3Ek__BackingField_5;
	// System.Boolean UnityEngine.Networking.UnityWebRequest::<disposeDownloadHandlerOnDispose>k__BackingField
	bool ___U3CdisposeDownloadHandlerOnDisposeU3Ek__BackingField_6;
	// System.Boolean UnityEngine.Networking.UnityWebRequest::<disposeUploadHandlerOnDispose>k__BackingField
	bool ___U3CdisposeUploadHandlerOnDisposeU3Ek__BackingField_7;
};
// Native definition for P/Invoke marshalling of UnityEngine.Networking.UnityWebRequest
struct UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
	DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB_marshaled_pinvoke ___m_DownloadHandler_1;
	UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6_marshaled_pinvoke ___m_UploadHandler_2;
	CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804_marshaled_pinvoke ___m_CertificateHandler_3;
	Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E* ___m_Uri_4;
	int32_t ___U3CdisposeCertificateHandlerOnDisposeU3Ek__BackingField_5;
	int32_t ___U3CdisposeDownloadHandlerOnDisposeU3Ek__BackingField_6;
	int32_t ___U3CdisposeUploadHandlerOnDisposeU3Ek__BackingField_7;
};
// Native definition for COM marshalling of UnityEngine.Networking.UnityWebRequest
struct UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F_marshaled_com
{
	intptr_t ___m_Ptr_0;
	DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB_marshaled_com* ___m_DownloadHandler_1;
	UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6_marshaled_com* ___m_UploadHandler_2;
	CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804_marshaled_com* ___m_CertificateHandler_3;
	Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E* ___m_Uri_4;
	int32_t ___U3CdisposeCertificateHandlerOnDisposeU3Ek__BackingField_5;
	int32_t ___U3CdisposeDownloadHandlerOnDisposeU3Ek__BackingField_6;
	int32_t ___U3CdisposeUploadHandlerOnDisposeU3Ek__BackingField_7;
};

// UnityEngine.Networking.UnityWebRequestAsyncOperation
struct UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C  : public AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C
{
	// UnityEngine.Networking.UnityWebRequest UnityEngine.Networking.UnityWebRequestAsyncOperation::<webRequest>k__BackingField
	UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* ___U3CwebRequestU3Ek__BackingField_2;
};
// Native definition for P/Invoke marshalling of UnityEngine.Networking.UnityWebRequestAsyncOperation
struct UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C_marshaled_pinvoke : public AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C_marshaled_pinvoke
{
	UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F_marshaled_pinvoke* ___U3CwebRequestU3Ek__BackingField_2;
};
// Native definition for COM marshalling of UnityEngine.Networking.UnityWebRequestAsyncOperation
struct UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C_marshaled_com : public AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C_marshaled_com
{
	UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F_marshaled_com* ___U3CwebRequestU3Ek__BackingField_2;
};

// UnityEngine.Networking.UploadHandlerRaw
struct UploadHandlerRaw_t0A24CF320CDF16F1BC6C5C086DE71A1908CBB91A  : public UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6
{
	// Unity.Collections.NativeArray`1<System.Byte> UnityEngine.Networking.UploadHandlerRaw::m_Payload
	NativeArray_1_t81F55263465517B73C455D3400CF67B4BADD85CF ___m_Payload_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Networking.UploadHandlerRaw
struct UploadHandlerRaw_t0A24CF320CDF16F1BC6C5C086DE71A1908CBB91A_marshaled_pinvoke : public UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6_marshaled_pinvoke
{
	NativeArray_1_t81F55263465517B73C455D3400CF67B4BADD85CF ___m_Payload_1;
};
// Native definition for COM marshalling of UnityEngine.Networking.UploadHandlerRaw
struct UploadHandlerRaw_t0A24CF320CDF16F1BC6C5C086DE71A1908CBB91A_marshaled_com : public UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6_marshaled_com
{
	NativeArray_1_t81F55263465517B73C455D3400CF67B4BADD85CF ___m_Payload_1;
};

// System.Action`1<UnityEngine.AsyncOperation>
struct Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB  : public MulticastDelegate_t
{
};

// System.Action`1<Unity.RemoteConfig.ConfigResponse>
struct Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E  : public MulticastDelegate_t
{
};

// System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>
struct Func_1_t2A08DEC58BFB76B9DDF49BCF555A3342127229B5  : public MulticastDelegate_t
{
};

// System.Func`2<Newtonsoft.Json.Linq.JProperty,System.String>
struct Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879  : public MulticastDelegate_t
{
};

// System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>
struct Func_3_t6491300EDE89815C2EE58365B51E0AE133B267AD  : public MulticastDelegate_t
{
};

// System.Func`3<System.Object,System.Object,System.Boolean>
struct Func_3_tFCEB9D8CEAECBF6D0AD5440F96C6F9010270CE79  : public MulticastDelegate_t
{
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031  : public RuntimeArray
{
	ALIGN_FIELD (8) uint8_t m_Items[1];

	inline uint8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint8_t value)
	{
		m_Items[index] = value;
	}
};
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248  : public RuntimeArray
{
	ALIGN_FIELD (8) String_t* m_Items[1];

	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Object>::ContainsKey(TKey)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_ContainsKey_m703047C213F7AB55C9DC346596287773A1F670CD_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___key0, const RuntimeMethod* method) ;
// TValue System.Collections.Generic.Dictionary`2<System.Object,System.Object>::get_Item(TKey)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Dictionary_2_get_Item_m4AAAECBE902A211BF2126E6AFA280AEF73A3E0D6_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___key0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::set_Item(TKey,TValue)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_set_Item_m1A840355E8EDAECEA9D0C6F5E51B248FAA449CBD_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___key0, RuntimeObject* ___value1, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m5B32FBC624618211EB461D59CFBB10E987FD1329_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, const RuntimeMethod* method) ;
// System.Void System.Action`1<Unity.RemoteConfig.ConfigResponse>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1__ctor_m77852814147BA0498380271637D56B354BC79167_gshared (Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) ;
// System.Collections.Generic.List`1/Enumerator<T> System.Collections.Generic.List`1<System.Object>::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A List_1_GetEnumerator_mD8294A7FA2BEB1929487127D476F8EC1CDC23BFC_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1/Enumerator<System.Object>::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_mD9DC3E3C3697830A4823047AB29A77DBBB5ED419_gshared (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1/Enumerator<System.Object>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
// TResult System.Func`3<System.Object,System.Object,System.Boolean>::Invoke(T1,T2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Func_3_Invoke_mC786FD8356E25F147BEF4CF07A587720613A2C12_gshared_inline (Func_3_tFCEB9D8CEAECBF6D0AD5440F96C6F9010270CE79* __this, RuntimeObject* ___arg10, RuntimeObject* ___arg21, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mE921CC8F29FBBDE7CC3209A0ED0D921D58D00BCB_gshared (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
// TResult System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>::Invoke()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964 Func_1_Invoke_mDD4D76DE063CBA57F374C98C27A50E8B72AE3BD5_gshared_inline (Func_1_t2A08DEC58BFB76B9DDF49BCF555A3342127229B5* __this, const RuntimeMethod* method) ;
// System.Void System.Action`1<System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1__ctor_m2E1DFA67718FC1A0B6E5DFEB78831FFE9C059EB4_gshared (Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) ;
// System.Void System.Action`1<Unity.RemoteConfig.ConfigResponse>::Invoke(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_m496875C3D21245101D0AC44B050159FC1FBFB390_gshared_inline (Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* __this, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___obj0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.Object,Unity.RemoteConfig.ConfigResponse>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m8FE77510962F663162DDDACAFF301A623A66FF1F_gshared (Dictionary_2_tBAAB91981CCB60D9FC4599D3CAA138B40CBA2CCF* __this, const RuntimeMethod* method) ;
// System.Collections.Generic.Dictionary`2/KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2<System.Object,System.Object>::get_Keys()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR KeyCollection_tB45A861D090B15129521119AE48ED3813820A974* Dictionary_2_get_Keys_m72D290F90654BFD683FA7AA7C63D9F4F692218B6_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, const RuntimeMethod* method) ;
// System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<TKey,TValue> System.Collections.Generic.Dictionary`2/KeyCollection<System.Object,System.Object>::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_t65CC956745B1180C04CE6C6910FB27C5F32BB9FF KeyCollection_GetEnumerator_m7E77FBA7DE2D3876EC02F396712C4AA5B1D535A5_gshared (KeyCollection_tB45A861D090B15129521119AE48ED3813820A974* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<System.Object,System.Object>::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_mEB2A61F3F3F420C1B1DFD5C74EEFD4BD7761BCF7_gshared (Enumerator_t65CC956745B1180C04CE6C6910FB27C5F32BB9FF* __this, const RuntimeMethod* method) ;
// TKey System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<System.Object,System.Object>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_mD6472FA27D28B9AE64A0FEF796C72ABBC2420EBF_gshared_inline (Enumerator_t65CC956745B1180C04CE6C6910FB27C5F32BB9FF* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.Object,Unity.RemoteConfig.ConfigResponse>::set_Item(TKey,TValue)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_set_Item_m812EC53F52BC976067653204534B55A75B8BF399_gshared (Dictionary_2_tBAAB91981CCB60D9FC4599D3CAA138B40CBA2CCF* __this, RuntimeObject* ___key0, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___value1, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<System.Object,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mB5E00F11BCA3AC963F9BA72659FA76B107863F3C_gshared (Enumerator_t65CC956745B1180C04CE6C6910FB27C5F32BB9FF* __this, const RuntimeMethod* method) ;
// TKey System.Collections.Generic.KeyValuePair`2<System.Object,System.Object>::get_Key()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Key_mBD8EA7557C27E6956F2AF29DA3F7499B2F51A282_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) ;
// TValue System.Collections.Generic.KeyValuePair`2<System.Object,System.Object>::get_Value()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) ;
// T Newtonsoft.Json.Linq.JToken::ToObject<Unity.RemoteConfig.ConfigResponse>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 JToken_ToObject_TisConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_mDE14C69A8F47BC3C3D33A3EED6D30FB2314F9EDA_gshared (JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* __this, const RuntimeMethod* method) ;
// FieldType UnityEngine.AndroidJavaObject::GetStatic<System.Object>(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* AndroidJavaObject_GetStatic_TisRuntimeObject_m4EF4E4761A0A6E99E0A298F653E8129B1494E4C9_gshared (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* __this, String_t* ___fieldName0, const RuntimeMethod* method) ;
// System.Void System.Nullable`1<System.Int32Enum>::.ctor(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Nullable_1__ctor_m5100B58428BDAD8C79F3D8576B0C2E1D4F3924EB_gshared (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, int32_t ___value0, const RuntimeMethod* method) ;
// T System.Nullable`1<System.Int32Enum>::GetValueOrDefault()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Nullable_1_GetValueOrDefault_m26287DBB36429B2E2FBCB3F96F439248F8CAA8BB_gshared_inline (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, const RuntimeMethod* method) ;
// System.Boolean System.Nullable`1<System.Int32Enum>::get_HasValue()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mB1F55188CDD50D6D725D41F55D2F2540CD15FB20_gshared_inline (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, const RuntimeMethod* method) ;
// U Newtonsoft.Json.Linq.Extensions::Value<System.Boolean>(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Extensions_Value_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m1DB6D797C74FDFDDAC6548EE8EA80DD90E9430A3_gshared (RuntimeObject* ___value0, const RuntimeMethod* method) ;
// U Newtonsoft.Json.Linq.Extensions::Value<System.Single>(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Extensions_Value_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_mC5F3E49729A00991AFA91AC1F88BD187279B96AE_gshared (RuntimeObject* ___value0, const RuntimeMethod* method) ;
// U Newtonsoft.Json.Linq.Extensions::Value<System.Int32>(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Extensions_Value_TisInt32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_m3092267C93448D476CE9F21D518B204704D234B8_gshared (RuntimeObject* ___value0, const RuntimeMethod* method) ;
// U Newtonsoft.Json.Linq.Extensions::Value<System.Object>(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Extensions_Value_TisRuntimeObject_mAF6EBA58652B6AD49FA0ABA70115C4B422647464_gshared (RuntimeObject* ___value0, const RuntimeMethod* method) ;
// U Newtonsoft.Json.Linq.Extensions::Value<System.Int64>(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Extensions_Value_TisInt64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_m6F4AADD3516AF69D3B4211A1CE328B7DE1F17145_gshared (RuntimeObject* ___value0, const RuntimeMethod* method) ;
// System.Void System.Func`2<System.Object,System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Func_2__ctor_m7F8A01C0B02BC1D4063F4EB1E817F7A48562A398_gshared (Func_2_tACBF5A1656250800CE861707354491F0611F6624* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) ;
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select<System.Object,System.Object>(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Enumerable_Select_TisRuntimeObject_TisRuntimeObject_m960CFE6ABFCB6C2399B69DEDFB27765D1FCE57A6_gshared (RuntimeObject* ___source0, Func_2_tACBF5A1656250800CE861707354491F0611F6624* ___selector1, const RuntimeMethod* method) ;
// TSource[] System.Linq.Enumerable::ToArray<System.Object>(System.Collections.Generic.IEnumerable`1<TSource>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* Enumerable_ToArray_TisRuntimeObject_m6B1F26FB2B3EA7B18B82FC81035440AAAEFCE924_gshared (RuntimeObject* ___source0, const RuntimeMethod* method) ;

// Unity.RemoteConfig.RuntimeConfig Unity.RemoteConfig.ConfigManagerImpl::get_appConfig()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* ConfigManagerImpl_get_appConfig_mD4AEBB6B75C89BD51F4150114F1464F6E019DE8A (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RuntimeConfig::add_FetchCompleted(System.Action`1<Unity.RemoteConfig.ConfigResponse>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig_add_FetchCompleted_mFDD787BA362A46B3C2CC3ED5B93D2007FC3C7338 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___value0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RuntimeConfig::remove_FetchCompleted(System.Action`1<Unity.RemoteConfig.ConfigResponse>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig_remove_FetchCompleted_m193774BB24681096DF02973B7F5F5B6A024F01AB (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___value0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.ConfigManagerImpl::set_appConfig(Unity.RemoteConfig.RuntimeConfig)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_set_appConfig_m48FADB6A02666D6EE5AE014D98A88B2630AAEC0C (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* ___value0, const RuntimeMethod* method) ;
// Unity.RemoteConfig.RuntimeConfig Unity.RemoteConfig.ConfigManagerImpl::GetConfig(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* ConfigManagerImpl_GetConfig_m98D77B1A47BAF896EC6AB0B94E08AEEA0AFDD9DA (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.ConfigManagerImpl::SetCustomUserID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_SetCustomUserID_m8FF642427B5C2302557A7B622BC567CDEDF767F3 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___customUserID0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.ConfigManagerImpl::SetEnvironmentID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_SetEnvironmentID_m1F29BFE714C5F7DCF688F3713BFB5A1A098B114A (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___environmentID0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.ConfigManagerImpl::SetPlayerIdentityToken(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ConfigManagerImpl_SetPlayerIdentityToken_m8485CA0DD7AE0E95B8FF3B8BCB08A62A0446A1B2_inline (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___identityToken0, const RuntimeMethod* method) ;
// Unity.RemoteConfig.ConfigResponse Unity.RemoteConfig.ConfigManagerImpl::ParseResponse(Unity.RemoteConfig.ConfigOrigin,System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ConfigManagerImpl_ParseResponse_m66ADE9C6AE574604ADA656D2233F8DE1F51DE897 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, int32_t ___origin0, Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___headers1, String_t* ___body2, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.ConfigManagerImpl::SaveCache(Unity.RemoteConfig.ConfigResponse)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_SaveCache_m43661F9802E18D7B3BDE3E372AF46D72E08FB5E4 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___response0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.ConfigManagerImpl::LoadFromCache()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_LoadFromCache_m308A9C3C2867E19A7348741D3BF09EBCAAE4D156 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.ConfigManagerImpl::.ctor(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl__ctor_m27834170D98EA71F6599F1170A361259240FF178 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___originService0, String_t* ___attributionMetadataStr1, String_t* ___cacheFileRC2, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.RuntimeConfig>::ContainsKey(TKey)
inline bool Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1 (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* __this, String_t* ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D*, String_t*, const RuntimeMethod*))Dictionary_2_ContainsKey_m703047C213F7AB55C9DC346596287773A1F670CD_gshared)(__this, ___key0, method);
}
// TValue System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.RuntimeConfig>::get_Item(TKey)
inline RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5 (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* __this, String_t* ___key0, const RuntimeMethod* method)
{
	return ((  RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* (*) (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D*, String_t*, const RuntimeMethod*))Dictionary_2_get_Item_m4AAAECBE902A211BF2126E6AFA280AEF73A3E0D6_gshared)(__this, ___key0, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.RuntimeConfig>::set_Item(TKey,TValue)
inline void Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842 (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* __this, String_t* ___key0, RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D*, String_t*, RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99*, const RuntimeMethod*))Dictionary_2_set_Item_m1A840355E8EDAECEA9D0C6F5E51B248FAA449CBD_gshared)(__this, ___key0, ___value1, method);
}
// System.Delegate System.Delegate::Combine(System.Delegate,System.Delegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t* Delegate_Combine_m8B9D24CED35033C7FC56501DFE650F5CB7FF012C (Delegate_t* ___a0, Delegate_t* ___b1, const RuntimeMethod* method) ;
// System.Delegate System.Delegate::Remove(System.Delegate,System.Delegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t* Delegate_Remove_m40506877934EC1AD4ADAE57F5E97AF0BC0F96116 (Delegate_t* ___source0, Delegate_t* ___value1, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>>::.ctor()
inline void List_1__ctor_mA28F18D77CFE93EBCAC6BD896325683999D261FD (List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>>::.ctor()
inline void List_1__ctor_m5F52BEE935E79774B7BEB5DF51F0AA696A0598C6 (List_1_t0829E916C4AAB917E57526AEED3AB682DB994946* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t0829E916C4AAB917E57526AEED3AB682DB994946*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.RuntimeConfig>::.ctor()
inline void Dictionary_2__ctor_m472ECA9A0B49BFD1553C6AFB1B926F2A9DC8E07B (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D*, const RuntimeMethod*))Dictionary_2__ctor_m5B32FBC624618211EB461D59CFBB10E987FD1329_gshared)(__this, method);
}
// System.Void Unity.RemoteConfig.RuntimeConfig::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig__ctor_m86B59B69E6F3D781991235921A872D8362417EF7 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___configType0, const RuntimeMethod* method) ;
// System.String UnityEngine.Application::get_cloudProjectId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Application_get_cloudProjectId_mC4A9551019BB135B39D816F55A912CC2E9858F84 (const RuntimeMethod* method) ;
// System.String UnityEngine.Analytics.AnalyticsSessionInfo::get_userId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AnalyticsSessionInfo_get_userId_mA331343A74FF5FB69F0478CCA03FE4872A3BA3D1 (const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Debug::get_isDebugBuild()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Debug_get_isDebugBuild_mD757482E7E84FD089E874DD0778A5200D12C14E0 (const RuntimeMethod* method) ;
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A (String_t* ___value0, const RuntimeMethod* method) ;
// Newtonsoft.Json.Linq.JObject Newtonsoft.Json.Linq.JObject::Parse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* JObject_Parse_mAFE39B83D08F5D889D34F83E017661FF28E4D0AC (String_t* ___json0, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mF8B69BE42B5C5ABCAD3C176FBBE3010E0815D65D (String_t* ___str00, String_t* ___str11, String_t* ___str22, String_t* ___str33, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogWarning(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogWarning_mEF15C6B17CE4E1FA7E379CDB82CE40FCD89A3F28 (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.UnityAttributes::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAttributes__ctor_mD96F9FE53FA0BF66C1E0BA6775522D429011742E (UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04* __this, const RuntimeMethod* method) ;
// System.Void System.Action`1<Unity.RemoteConfig.ConfigResponse>::.ctor(System.Object,System.IntPtr)
inline void Action_1__ctor_m77852814147BA0498380271637D56B354BC79167 (Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*, RuntimeObject*, intptr_t, const RuntimeMethod*))Action_1__ctor_m77852814147BA0498380271637D56B354BC79167_gshared)(__this, ___object0, ___method1, method);
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::add_FetchCompleted(System.Action`1<Unity.RemoteConfig.ConfigResponse>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_add_FetchCompleted_mF6B19CF75E17DC81214E790E96952CBED147163E (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___value0, const RuntimeMethod* method) ;
// System.Collections.Generic.List`1/Enumerator<T> System.Collections.Generic.List`1<System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>>::GetEnumerator()
inline Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803 List_1_GetEnumerator_m3465F03E8555CE28FCA9069FE1CD237725DF45F2 (List_1_t0829E916C4AAB917E57526AEED3AB682DB994946* __this, const RuntimeMethod* method)
{
	return ((  Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803 (*) (List_1_t0829E916C4AAB917E57526AEED3AB682DB994946*, const RuntimeMethod*))List_1_GetEnumerator_mD8294A7FA2BEB1929487127D476F8EC1CDC23BFC_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1/Enumerator<System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>>::Dispose()
inline void Enumerator_Dispose_m1DEFE09EF1D0A3CE3C51A4A06C471B5A272939FE (Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803* __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803*, const RuntimeMethod*))Enumerator_Dispose_mD9DC3E3C3697830A4823047AB29A77DBBB5ED419_gshared)(__this, method);
}
// T System.Collections.Generic.List`1/Enumerator<System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>>::get_Current()
inline Func_3_t6491300EDE89815C2EE58365B51E0AE133B267AD* Enumerator_get_Current_mC9EFE54C2C30BA46A2066277788398580C887257_inline (Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803* __this, const RuntimeMethod* method)
{
	return ((  Func_3_t6491300EDE89815C2EE58365B51E0AE133B267AD* (*) (Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803*, const RuntimeMethod*))Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline)(__this, method);
}
// TResult System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>::Invoke(T1,T2)
inline bool Func_3_Invoke_m4BC1396C95F81B081501D01E5109A00A49631968_inline (Func_3_t6491300EDE89815C2EE58365B51E0AE133B267AD* __this, Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___arg10, String_t* ___arg21, const RuntimeMethod* method)
{
	return ((  bool (*) (Func_3_t6491300EDE89815C2EE58365B51E0AE133B267AD*, Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83*, String_t*, const RuntimeMethod*))Func_3_Invoke_mC786FD8356E25F147BEF4CF07A587720613A2C12_gshared_inline)(__this, ___arg10, ___arg21, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Func`3<System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String,System.Boolean>>::MoveNext()
inline bool Enumerator_MoveNext_m0CDA887E6760543D0ABE8722B4DE088D49F87F85 (Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803*, const RuntimeMethod*))Enumerator_MoveNext_mE921CC8F29FBBDE7CC3209A0ED0D921D58D00BCB_gshared)(__this, method);
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::PostConfigWithConfigType(System.String,System.Object,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_PostConfigWithConfigType_m339D300603127623CA9B42D34FE1CC32C25CE4CA (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, RuntimeObject* ___userAttributes1, RuntimeObject* ___appAttributes2, RuntimeObject* ___filterAttributes3, const RuntimeMethod* method) ;
// System.String Unity.RemoteConfig.ConfigManagerImpl::PreparePayloadWithConfigType(System.String,System.Object,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ConfigManagerImpl_PreparePayloadWithConfigType_m552029F4263A0049E7EFA472AA12CC08CAECCF2E (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, RuntimeObject* ___userAttributes1, RuntimeObject* ___appAttributes2, RuntimeObject* ___filterAttributes3, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.ConfigManagerImpl::DoRequest(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_DoRequest_m82B45FDFBC6F8CB5F6EA90C6673FD99F2846AEBD (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, String_t* ___jsonText1, const RuntimeMethod* method) ;
// Newtonsoft.Json.Linq.JObject Newtonsoft.Json.Linq.JObject::FromObject(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* JObject_FromObject_m5173BDC2D9FC1B112F5895863E74860550DE915B (RuntimeObject* ___o0, const RuntimeMethod* method) ;
// Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JToken::op_Implicit(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* JToken_op_Implicit_mDB27F16361965B574E95F791BE9E5459EA77CC95 (String_t* ___value0, const RuntimeMethod* method) ;
// System.Void Newtonsoft.Json.Linq.JObject::set_Item(System.String,Newtonsoft.Json.Linq.JToken)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JObject_set_Item_m38ACF4BABEDE80CF0138DA900AFFC5C4CC3E9221 (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* __this, String_t* ___propertyName0, JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* ___value1, const RuntimeMethod* method) ;
// System.Void Newtonsoft.Json.Linq.JObject::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JObject__ctor_mF7F801B6729F7309319FF97690BCC68C7CA81CE4 (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* __this, const RuntimeMethod* method) ;
// Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JObject::get_Item(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* __this, String_t* ___propertyName0, const RuntimeMethod* method) ;
// UnityEngine.RuntimePlatform UnityEngine.Application::get_platform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Application_get_platform_m1AB34E71D9885B120F6021EB2B11DCB28CD6008D (const RuntimeMethod* method) ;
// System.String System.Enum::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Enum_ToString_m946B0B83C4470457D0FF555D862022C72BB55741 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Boolean Newtonsoft.Json.Linq.JObject::ContainsKey(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool JObject_ContainsKey_m6B74EB007B052D50B2D7502999216B2CE62BBEF2 (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* __this, String_t* ___propertyName0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.ConfigManagerImpl/<>c__DisplayClass35_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass35_0__ctor_m88EE9567C366B10DDD2BB95173880695FCADE028 (U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* __this, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest__ctor_m87B241477692D8A5E928205EB7E3EBB215675576 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest__ctor_m68DB029AEF4E6093EDC2196C980134D2C0C969CA (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_unityWebRequest(UnityEngine.Networking.UnityWebRequest)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_unityWebRequest_mEDEA0F5931A89608EB82EDE6408C25BA6F809C11 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* ___value0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_method(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_method_mF644FCA7FE27EAD29819E54765546CFCFA143394 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::SetRequestHeader(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_SetRequestHeader_m4FB2E5E9AB59662AA749545FB0CCAD944AFF504F (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, String_t* ___name0, String_t* ___value1, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_timeout(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_timeout_m4A61D4CC6F764D6AAC1117BCB8A066FE191F0B2F (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, int32_t ___value0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_url(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_url_m75133D4C34C7305F8EED05A6B31A743A56D71899 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method) ;
// System.Collections.Generic.List`1/Enumerator<T> System.Collections.Generic.List`1<System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>>::GetEnumerator()
inline Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8 List_1_GetEnumerator_mA5F623247EAF5110C665A71C65BE424E21AC8798 (List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C* __this, const RuntimeMethod* method)
{
	return ((  Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8 (*) (List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C*, const RuntimeMethod*))List_1_GetEnumerator_mD8294A7FA2BEB1929487127D476F8EC1CDC23BFC_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1/Enumerator<System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>>::Dispose()
inline void Enumerator_Dispose_m02ABAE8BB0E4A6356F33117FC781FB5E8F04C680 (Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8* __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8*, const RuntimeMethod*))Enumerator_Dispose_mD9DC3E3C3697830A4823047AB29A77DBBB5ED419_gshared)(__this, method);
}
// T System.Collections.Generic.List`1/Enumerator<System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>>::get_Current()
inline Func_1_t2A08DEC58BFB76B9DDF49BCF555A3342127229B5* Enumerator_get_Current_m74F27D7302F75A8327373EC0A364AFC11ADD0E76_inline (Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8* __this, const RuntimeMethod* method)
{
	return ((  Func_1_t2A08DEC58BFB76B9DDF49BCF555A3342127229B5* (*) (Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8*, const RuntimeMethod*))Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline)(__this, method);
}
// TResult System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>::Invoke()
inline RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964 Func_1_Invoke_mDD4D76DE063CBA57F374C98C27A50E8B72AE3BD5_inline (Func_1_t2A08DEC58BFB76B9DDF49BCF555A3342127229B5* __this, const RuntimeMethod* method)
{
	return ((  RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964 (*) (Func_1_t2A08DEC58BFB76B9DDF49BCF555A3342127229B5*, const RuntimeMethod*))Func_1_Invoke_mDD4D76DE063CBA57F374C98C27A50E8B72AE3BD5_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Func`1<Unity.RemoteConfig.RequestHeaderTuple>>::MoveNext()
inline bool Enumerator_MoveNext_m33E4BFC93CB232DD900322131149D15FF22FF12B (Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8*, const RuntimeMethod*))Enumerator_MoveNext_mE921CC8F29FBBDE7CC3209A0ED0D921D58D00BCB_gshared)(__this, method);
}
// System.Text.Encoding System.Text.Encoding::get_UTF8()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* Encoding_get_UTF8_m9700ADA8E0F244002B2A89B483F1B2133B8FE336 (const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UploadHandlerRaw::.ctor(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UploadHandlerRaw__ctor_m168C957B67E29CB3072E3542044D37E2F16C42B7 (UploadHandlerRaw_t0A24CF320CDF16F1BC6C5C086DE71A1908CBB91A* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___data0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_uploadHandler(UnityEngine.Networking.UploadHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_uploadHandler_mCAC1021CD5A38F85FD3CC03EC5227562D385DE6D (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6* ___value0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.DownloadHandlerBuffer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DownloadHandlerBuffer__ctor_m5EE7C9E8AB468B2B937A7C9C66B4176A884147AF (DownloadHandlerBuffer_t34C626F6513FA9A44FDDDEE85455CF2CD9DA5974* __this, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_downloadHandler(UnityEngine.Networking.DownloadHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_downloadHandler_m17CAEC803C5C70D872206FD3BE6271AC39102924 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* ___value0, const RuntimeMethod* method) ;
// UnityEngine.Networking.UnityWebRequestAsyncOperation Unity.RemoteConfig.RCUnityWebRequest::SendWebRequest()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C* RCUnityWebRequest_SendWebRequest_m45E3D6DB2C4C4EF78C6D48674D583CEC27D77683 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) ;
// System.Void System.Action`1<UnityEngine.AsyncOperation>::.ctor(System.Object,System.IntPtr)
inline void Action_1__ctor_m33ABB7530487276910BEFB499A97D33FB2E06D7D (Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB*, RuntimeObject*, intptr_t, const RuntimeMethod*))Action_1__ctor_m2E1DFA67718FC1A0B6E5DFEB78831FFE9C059EB4_gshared)(__this, ___object0, ___method1, method);
}
// System.Void UnityEngine.AsyncOperation::add_completed(System.Action`1<UnityEngine.AsyncOperation>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncOperation_add_completed_mD6F21BA8127D6D4B7ABDEFAA995A7A347A20A793 (AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C* __this, Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB* ___value0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RuntimeConfig::HandleConfigResponse(Unity.RemoteConfig.ConfigResponse)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig_HandleConfigResponse_mF33BFEEFEA29FE9B434CFF49D921AA7305D1A021 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___configResponse0, const RuntimeMethod* method) ;
// System.Void System.Action`1<Unity.RemoteConfig.ConfigResponse>::Invoke(T)
inline void Action_1_Invoke_m496875C3D21245101D0AC44B050159FC1FBFB390_inline (Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* __this, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871, const RuntimeMethod*))Action_1_Invoke_m496875C3D21245101D0AC44B050159FC1FBFB390_gshared_inline)(__this, ___obj0, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.ConfigResponse>::.ctor()
inline void Dictionary_2__ctor_mCF1D722A2A472811B0A1D81205BD73AD064AFDC1 (Dictionary_2_t1350928D43387352EDB22C6979983B8129804127* __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t1350928D43387352EDB22C6979983B8129804127*, const RuntimeMethod*))Dictionary_2__ctor_m8FE77510962F663162DDDACAFF301A623A66FF1F_gshared)(__this, method);
}
// System.Collections.Generic.Dictionary`2/KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.RuntimeConfig>::get_Keys()
inline KeyCollection_tDABE6E934B2EF300EC234A664076A202E3BFA4BE* Dictionary_2_get_Keys_m0A27AAFC34C1E6AC8FFA238F61151F2C22748599 (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* __this, const RuntimeMethod* method)
{
	return ((  KeyCollection_tDABE6E934B2EF300EC234A664076A202E3BFA4BE* (*) (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D*, const RuntimeMethod*))Dictionary_2_get_Keys_m72D290F90654BFD683FA7AA7C63D9F4F692218B6_gshared)(__this, method);
}
// System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<TKey,TValue> System.Collections.Generic.Dictionary`2/KeyCollection<System.String,Unity.RemoteConfig.RuntimeConfig>::GetEnumerator()
inline Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B KeyCollection_GetEnumerator_m9CE20FA88F49E3AC89C3194787B1698BB7A0F700 (KeyCollection_tDABE6E934B2EF300EC234A664076A202E3BFA4BE* __this, const RuntimeMethod* method)
{
	return ((  Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B (*) (KeyCollection_tDABE6E934B2EF300EC234A664076A202E3BFA4BE*, const RuntimeMethod*))KeyCollection_GetEnumerator_m7E77FBA7DE2D3876EC02F396712C4AA5B1D535A5_gshared)(__this, method);
}
// System.Void System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<System.String,Unity.RemoteConfig.RuntimeConfig>::Dispose()
inline void Enumerator_Dispose_m62199928E4E61AF736738A346A85DC979AF27D2C (Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B* __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B*, const RuntimeMethod*))Enumerator_Dispose_mEB2A61F3F3F420C1B1DFD5C74EEFD4BD7761BCF7_gshared)(__this, method);
}
// TKey System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<System.String,Unity.RemoteConfig.RuntimeConfig>::get_Current()
inline String_t* Enumerator_get_Current_m7AA79A472AE62BDA8AE5DACD99FF84BEF4DE800E_inline (Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B* __this, const RuntimeMethod* method)
{
	return ((  String_t* (*) (Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B*, const RuntimeMethod*))Enumerator_get_Current_mD6472FA27D28B9AE64A0FEF796C72ABBC2420EBF_gshared_inline)(__this, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.String,Unity.RemoteConfig.ConfigResponse>::set_Item(TKey,TValue)
inline void Dictionary_2_set_Item_m946DA5F7EED6E700A1D4B25A93897A1248ED5A70 (Dictionary_2_t1350928D43387352EDB22C6979983B8129804127* __this, String_t* ___key0, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t1350928D43387352EDB22C6979983B8129804127*, String_t*, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871, const RuntimeMethod*))Dictionary_2_set_Item_m812EC53F52BC976067653204534B55A75B8BF399_gshared)(__this, ___key0, ___value1, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<System.String,Unity.RemoteConfig.RuntimeConfig>::MoveNext()
inline bool Enumerator_MoveNext_m203F36D1E99FED6FCC96C594AE5D5B70981FD140 (Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B*, const RuntimeMethod*))Enumerator_MoveNext_mB5E00F11BCA3AC963F9BA72659FA76B107863F3C_gshared)(__this, method);
}
// System.String UnityEngine.Application::get_persistentDataPath()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Application_get_persistentDataPath_m787EBC9B0862E7617DCD6CABD2147E61717EAC17 (const RuntimeMethod* method) ;
// System.String System.IO.Path::Combine(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_Combine_m64754D4E08990CE1EBC41CDF197807EE4B115474 (String_t* ___path10, String_t* ___path21, const RuntimeMethod* method) ;
// System.IO.StreamWriter System.IO.File::CreateText(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StreamWriter_t6E7DF7D524AA3C018A65F62EE80779873ED4D1E4* File_CreateText_mC919C8F57836A16849C3143D6EC71A6DF9BBC95C (String_t* ___path0, const RuntimeMethod* method) ;
// System.String Newtonsoft.Json.JsonConvert::SerializeObject(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* JsonConvert_SerializeObject_mEF78C5DAFDB944E8E19657EB92F5394370B27CAF (RuntimeObject* ___value0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_m059825802BB6AF7EA9693FEBEEB0D85F59A3E38E (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// System.IO.FileStream System.IO.File::Open(System.String,System.IO.FileMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* File_Open_m9C6D5876B037A5A8341D216B767D4C8BE7084326 (String_t* ___path0, int32_t ___mode1, const RuntimeMethod* method) ;
// System.Text.Encoding System.Text.Encoding::get_ASCII()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* Encoding_get_ASCII_mCC17A741582B0AB778D261452FD515EBD7297562 (const RuntimeMethod* method) ;
// System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,Newtonsoft.Json.Linq.JToken>> Newtonsoft.Json.Linq.JObject::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* JObject_GetEnumerator_mDB9AA9D5339E5EFD3D9D968B778E651D2CA693BB (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* __this, const RuntimeMethod* method) ;
// TKey System.Collections.Generic.KeyValuePair`2<System.String,Newtonsoft.Json.Linq.JToken>::get_Key()
inline String_t* KeyValuePair_2_get_Key_m58D71AFA188B3B9B9C6FFE10C720DE49333F1A08_inline (KeyValuePair_2_t25BF56B44F40AC19698F68DD29593E307D428F8B* __this, const RuntimeMethod* method)
{
	return ((  String_t* (*) (KeyValuePair_2_t25BF56B44F40AC19698F68DD29593E307D428F8B*, const RuntimeMethod*))KeyValuePair_2_get_Key_mBD8EA7557C27E6956F2AF29DA3F7499B2F51A282_gshared_inline)(__this, method);
}
// TValue System.Collections.Generic.KeyValuePair`2<System.String,Newtonsoft.Json.Linq.JToken>::get_Value()
inline JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* KeyValuePair_2_get_Value_m2BC92622340FE4FDF5ECB521489A8AC781D8BA19_inline (KeyValuePair_2_t25BF56B44F40AC19698F68DD29593E307D428F8B* __this, const RuntimeMethod* method)
{
	return ((  JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* (*) (KeyValuePair_2_t25BF56B44F40AC19698F68DD29593E307D428F8B*, const RuntimeMethod*))KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline)(__this, method);
}
// T Newtonsoft.Json.Linq.JToken::ToObject<Unity.RemoteConfig.ConfigResponse>()
inline ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 JToken_ToObject_TisConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_mDE14C69A8F47BC3C3D33A3EED6D30FB2314F9EDA (JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* __this, const RuntimeMethod* method)
{
	return ((  ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 (*) (JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3*, const RuntimeMethod*))JToken_ToObject_TisConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_mDE14C69A8F47BC3C3D33A3EED6D30FB2314F9EDA_gshared)(__this, method);
}
// System.Void UnityEngine.Debug::Log(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_Log_m86567BCF22BBE7809747817453CACA0E41E68219 (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// UnityEngine.Networking.UnityWebRequest UnityEngine.Networking.UnityWebRequestAsyncOperation::get_webRequest()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* UnityWebRequestAsyncOperation_get_webRequest_mF67D15420C7C1C4DCA1BD6F839048A0542998BC3_inline (UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Networking.UnityWebRequest::get_isHttpError()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool UnityWebRequest_get_isHttpError_m945BA480A179E05CC9659846414D9521ED648ED5 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Networking.UnityWebRequest::get_isNetworkError()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool UnityWebRequest_get_isNetworkError_m036684411466688E71E67CDD3703BAC9035A56F0 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.ConfigManagerImpl::HandleConfigResponse(System.String,Unity.RemoteConfig.ConfigResponse)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_HandleConfigResponse_m8A7939905898FE82F01194EF38C55DABCFD362D0 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___configResponse1, const RuntimeMethod* method) ;
// System.Collections.Generic.Dictionary`2<System.String,System.String> Unity.RemoteConfig.RCUnityWebRequest::GetResponseHeaders()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* RCUnityWebRequest_GetResponseHeaders_mD82C15C8DCE779536154FABB25B151FB80F2992D (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) ;
// UnityEngine.Networking.DownloadHandler Unity.RemoteConfig.RCUnityWebRequest::get_downloadHandler()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* RCUnityWebRequest_get_downloadHandler_mFD12B9B005ECD0E5DB8DED43970F986427B6D148 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) ;
// System.String UnityEngine.Networking.DownloadHandler::get_text()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DownloadHandler_get_text_mA6DE5CB2647A21E577B963708DC3D0DA4DBFE7D8 (DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_Dispose_m9F43494C0FEA530A97D3F2AF3D425CCC7670753A (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.String UnityEngine.SystemInfo::get_operatingSystem()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SystemInfo_get_operatingSystem_m441DFAEFA81C9B5AF19D5C486469EDBD674490A8 (const RuntimeMethod* method) ;
// System.String UnityEngine.Application::get_version()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Application_get_version_mD6AC9813ABCAD4D2A1F764F99E26068CA5B830F2 (const RuntimeMethod* method) ;
// UnityEngine.ApplicationSandboxType UnityEngine.Application::get_sandboxType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Application_get_sandboxType_m612A691D946B19DFAF0211D77047EFFA0C9D3E85 (const RuntimeMethod* method) ;
// System.String Unity.RemoteConfig.UnityAttributes::GetDeviceModel()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityAttributes_GetDeviceModel_mE18196FBE4733B5F7F8DAFE82FAEB2ED8DE5C071 (UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04* __this, const RuntimeMethod* method) ;
// System.String UnityEngine.SystemInfo::get_processorType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SystemInfo_get_processorType_mFF77AA1DFEF20F32947689FC751856CD7FB0D211 (const RuntimeMethod* method) ;
// System.Int32 UnityEngine.SystemInfo::get_processorCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SystemInfo_get_processorCount_m9161DEC1BC6A1D2431C23A291D3EDB288C2D9BD0 (const RuntimeMethod* method) ;
// System.Int32 UnityEngine.SystemInfo::get_processorFrequency()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SystemInfo_get_processorFrequency_mEE3979653401947B835DA2F61DDEE1665610DC55 (const RuntimeMethod* method) ;
// System.Int32 UnityEngine.SystemInfo::get_systemMemorySize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SystemInfo_get_systemMemorySize_mB292B50D7F2F0AF1A450A87F3A883E4ABEC00D89 (const RuntimeMethod* method) ;
// System.Int32 UnityEngine.SystemInfo::get_graphicsMemorySize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SystemInfo_get_graphicsMemorySize_m53DF8C3C07E8A470CB0308C234B032F5CAA893DE (const RuntimeMethod* method) ;
// UnityEngine.Resolution UnityEngine.Screen::get_currentResolution()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Resolution_tDF215F567EEFFD07B9A8FB7CEACC08EA6B8B9525 Screen_get_currentResolution_mDA9FEB72E2C16BD66D709E94CD9504BF7CAC899E (const RuntimeMethod* method) ;
// System.String UnityEngine.Resolution::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Resolution_ToString_m058CE120CC83F314D0C8D4A706F9AA068BC9CF34 (Resolution_tDF215F567EEFFD07B9A8FB7CEACC08EA6B8B9525* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Screen::get_dpi()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Screen_get_dpi_mD5BB95E605FABD335F0D4736EE4860A0AA98A50D (const RuntimeMethod* method) ;
// UnityEngine.SystemLanguage UnityEngine.Application::get_systemLanguage()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Application_get_systemLanguage_mF0C8FBE854F7B58315A61087619DD10CB53A9AFF (const RuntimeMethod* method) ;
// System.String Unity.RemoteConfig.UnityAttributes::GetISOCodeFromLangStruct(UnityEngine.SystemLanguage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityAttributes_GetISOCodeFromLangStruct_m476952E31CCED8A496E40D5D10B900A0768A8CCD (UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04* __this, int32_t ___systemLanguage0, const RuntimeMethod* method) ;
// System.String UnityEngine.Application::get_identifier()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Application_get_identifier_m26B38D49FA10A46D61C1309769A59E9CF7460006 (const RuntimeMethod* method) ;
// UnityEngine.ApplicationInstallMode UnityEngine.Application::get_installMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Application_get_installMode_mFE49B5A5A95880484D03C42020D3557B3632F168 (const RuntimeMethod* method) ;
// System.String UnityEngine.Application::get_installerName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Application_get_installerName_m6664FDA245FFA5B28B2C91E3D27547310FE5A37A (const RuntimeMethod* method) ;
// System.Int32 UnityEngine.SystemInfo::get_graphicsDeviceID()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SystemInfo_get_graphicsDeviceID_mE5A03FCF2980DDC6C95486C950B77B94B06B2520 (const RuntimeMethod* method) ;
// System.Int32 UnityEngine.SystemInfo::get_graphicsDeviceVendorID()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SystemInfo_get_graphicsDeviceVendorID_m68EB5BF8E909EB60168504F3C894DCD9DF07D8D3 (const RuntimeMethod* method) ;
// System.String UnityEngine.SystemInfo::get_graphicsDeviceName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SystemInfo_get_graphicsDeviceName_m29D97187ADB983D77438384BBD77F0BC48731122 (const RuntimeMethod* method) ;
// System.String UnityEngine.SystemInfo::get_graphicsDeviceVendor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SystemInfo_get_graphicsDeviceVendor_m83FB2B269311C74F8B6A1EF00C0502FA3E30CD98 (const RuntimeMethod* method) ;
// System.String UnityEngine.SystemInfo::get_graphicsDeviceVersion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SystemInfo_get_graphicsDeviceVersion_m3BD3A18E1F8A3F88D9022A01E0B39E13B9392F4B (const RuntimeMethod* method) ;
// System.Int32 UnityEngine.SystemInfo::get_graphicsShaderLevel()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SystemInfo_get_graphicsShaderLevel_mA9BA383B643FD022F8AFAF445B63B6554D88D27C (const RuntimeMethod* method) ;
// System.Int32 UnityEngine.SystemInfo::get_maxTextureSize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SystemInfo_get_maxTextureSize_mB4272D4D85179CEF11FF1CDB3E8F3786D10CA04E (const RuntimeMethod* method) ;
// System.Void UnityEngine.AndroidJavaClass::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AndroidJavaClass__ctor_mB5466169E1151B8CC44C8FED234D79984B431389 (AndroidJavaClass_tE6296B30CC4BF84434A9B765267F3FD0DD8DDB03* __this, String_t* ___className0, const RuntimeMethod* method) ;
// FieldType UnityEngine.AndroidJavaObject::GetStatic<System.String>(System.String)
inline String_t* AndroidJavaObject_GetStatic_TisString_t_mF408A1C0C6E5BF8154F00A450A97A51B2ABFCBDE (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* __this, String_t* ___fieldName0, const RuntimeMethod* method)
{
	return ((  String_t* (*) (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0*, String_t*, const RuntimeMethod*))AndroidJavaObject_GetStatic_TisRuntimeObject_m4EF4E4761A0A6E99E0A298F653E8129B1494E4C9_gshared)(__this, ___fieldName0, method);
}
// System.String System.String::Format(System.String,System.Object,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_m76BF8F3A6AD789E38B708848A2688D400AAC250A (String_t* ___format0, RuntimeObject* ___arg01, RuntimeObject* ___arg12, RuntimeObject* ___arg23, const RuntimeMethod* method) ;
// UnityEngine.Networking.UnityWebRequest Unity.RemoteConfig.RCUnityWebRequest::get__unityWebRequest()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Networking.UnityWebRequest::get_downloadProgress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float UnityWebRequest_get_downloadProgress_m28B3DB759530A61929D8AB02A4482AB21D3348B1 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.UInt64 UnityEngine.Networking.UnityWebRequest::get_uploadedBytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint64_t UnityWebRequest_get_uploadedBytes_mA1DA52CB702E41CB42D0A8809AA80D642976B0D4 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.UInt64 UnityEngine.Networking.UnityWebRequest::get_downloadedBytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint64_t UnityWebRequest_get_downloadedBytes_m73E3EC726E417FC7F983FFEF9566CF380F322610 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Networking.UnityWebRequest::get_redirectLimit()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t UnityWebRequest_get_redirectLimit_m309E1021E1F5FCF64FB13B77D6585F2405605E71 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_redirectLimit(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_redirectLimit_m76AB0F549B698400B2BB3034493D3540A697C17A (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, int32_t ___value0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Networking.UnityWebRequest::get_chunkedTransfer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool UnityWebRequest_get_chunkedTransfer_m3DF3181EE21AE9F74FE4C9F7E4192A3A8028AC0E (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_chunkedTransfer(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_chunkedTransfer_m6B69044F190F3964D48DCADBDD46B231F1B8E058 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Networking.UnityWebRequest::get_isDone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool UnityWebRequest_get_isDone_m3079B53A1CAFD8D5B334C635761E7B7E10B14123 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.String UnityEngine.Networking.UnityWebRequest::get_url()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityWebRequest_get_url_mA3BF205A6FCA2BF66A62174182BE84553CE3FFA8 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_url(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_set_url_m5C117F8E00BA03DDC9EBC859DCB31BB4B6E3ECFC (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.Uri UnityEngine.Networking.UnityWebRequest::get_uri()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E* UnityWebRequest_get_uri_m12BEAEDE0E840ABE7B4B69528EB756BDA423A8F9 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_uri(System.Uri)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_set_uri_m273584DE722413D238FB04EA0AE5F35A580272C6 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E* ___value0, const RuntimeMethod* method) ;
// System.Int64 UnityEngine.Networking.UnityWebRequest::get_responseCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t UnityWebRequest_get_responseCode_m012C177F61435D5D120A21D7A03FFF7B0F8B904B (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Networking.UnityWebRequest::get_uploadProgress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float UnityWebRequest_get_uploadProgress_m3D2DCD424E0435ABAC0F84EE857121E839652F95 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Networking.UnityWebRequest::get_isModifiable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool UnityWebRequest_get_isModifiable_m8B2DA7C5B43443C4262BB0289141A608E2695D77 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Networking.UnityWebRequest::get_disposeUploadHandlerOnDispose()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool UnityWebRequest_get_disposeUploadHandlerOnDispose_m909CC9BEACAC26C87F44AA957B8F5E5CD10F5761_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_disposeUploadHandlerOnDispose(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityWebRequest_set_disposeUploadHandlerOnDispose_mFE16234F005357FECF4A45F842D17C0C52B7CA6E_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, bool ___value0, const RuntimeMethod* method) ;
// System.String UnityEngine.Networking.UnityWebRequest::get_method()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityWebRequest_get_method_mEA8B59A692AEF09BF469AB6A8B5A8F8C22435AB9 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_method(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_set_method_m35F9B5C788C66EACF3FB36FA220AA6B6777CFE88 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.String UnityEngine.Networking.UnityWebRequest::get_error()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityWebRequest_get_error_m20A5D813ED59118B7AA1D1E2EB5250178B1F5B6F (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Networking.UnityWebRequest::get_useHttpContinue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool UnityWebRequest_get_useHttpContinue_m52F5E404A60E72AD0A6D348B39738CEE9CF2A542 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_useHttpContinue(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_set_useHttpContinue_m69A9328F59DD88D26472A60530C42DB1D770571E (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set__unityWebRequest(UnityEngine.Networking.UnityWebRequest)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RCUnityWebRequest_set__unityWebRequest_m7D0EA20714CEA31EC9033AD41B64EABC892B3D2F_inline (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* ___value0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Networking.UnityWebRequest::get_disposeCertificateHandlerOnDispose()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool UnityWebRequest_get_disposeCertificateHandlerOnDispose_m5BF6519F2982ABA7912948690570F7729EDF25E9_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_disposeCertificateHandlerOnDispose(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityWebRequest_set_disposeCertificateHandlerOnDispose_m5EFCAF91A547716C4ACA5FB546E991B79E3D0E2A_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Networking.UnityWebRequest::get_disposeDownloadHandlerOnDispose()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool UnityWebRequest_get_disposeDownloadHandlerOnDispose_mA5E23BB2B931F6EF089C732D0E56E1B7F9FC1C54_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_disposeDownloadHandlerOnDispose(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityWebRequest_set_disposeDownloadHandlerOnDispose_m1BF640E233D231F8C0333864C0FE5D9E1DC2E7C6_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, bool ___value0, const RuntimeMethod* method) ;
// UnityEngine.Networking.DownloadHandler UnityEngine.Networking.UnityWebRequest::get_downloadHandler()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* UnityWebRequest_get_downloadHandler_m1AA91B23D9D594A4F4FE2975FC356C508528F1D5 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_downloadHandler(UnityEngine.Networking.DownloadHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_set_downloadHandler_m6CB94492012097DFC44E5773D1A627753788292F (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* ___value0, const RuntimeMethod* method) ;
// UnityEngine.Networking.CertificateHandler UnityEngine.Networking.UnityWebRequest::get_certificateHandler()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804* UnityWebRequest_get_certificateHandler_m928A7BE34EB3725EA1D977877B7362E813918D7D (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_certificateHandler(UnityEngine.Networking.CertificateHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_set_certificateHandler_m4B4FA1E2F5FD0394D079CB711EB612F6A62458E2 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804* ___value0, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Networking.UnityWebRequest::get_timeout()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t UnityWebRequest_get_timeout_mE7983CCB87576C0BF53D22A6BC79AC5191BB4927 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_timeout(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_set_timeout_mE9C8169FA8CF1BE17E3D9FDACDC6E1A9508DF618 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, int32_t ___value0, const RuntimeMethod* method) ;
// UnityEngine.Networking.UploadHandler UnityEngine.Networking.UnityWebRequest::get_uploadHandler()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6* UnityWebRequest_get_uploadHandler_mF92ED2E0410E7F720B8775B467CFD86B60909CF5 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::set_uploadHandler(UnityEngine.Networking.UploadHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_set_uploadHandler_m68F346550136DE178C79238944985892196027FE (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6* ___value0, const RuntimeMethod* method) ;
// UnityEngine.Networking.UnityWebRequestAsyncOperation UnityEngine.Networking.UnityWebRequest::SendWebRequest()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C* UnityWebRequest_SendWebRequest_mA3CD13983BAA5074A0640EDD661B1E46E6DB6C13 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::Abort()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_Abort_m466E8B88BC90F64CE614561BAA88B9412BDB7E8B (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// System.String UnityEngine.Networking.UnityWebRequest::GetRequestHeader(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityWebRequest_GetRequestHeader_mEDAC73EA86F30AE1438EBD3452AA927359437076 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, String_t* ___name0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Networking.UnityWebRequest::SetRequestHeader(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityWebRequest_SetRequestHeader_m099734EB787B7269B62AB2236A5A4F7D35AF8BC5 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, String_t* ___name0, String_t* ___value1, const RuntimeMethod* method) ;
// System.String UnityEngine.Networking.UnityWebRequest::GetResponseHeader(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityWebRequest_GetResponseHeader_m9AC0E1BB43CE0469BC7FE865B3D9B2C4198DDF03 (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, String_t* ___name0, const RuntimeMethod* method) ;
// System.Collections.Generic.Dictionary`2<System.String,System.String> UnityEngine.Networking.UnityWebRequest::GetResponseHeaders()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* UnityWebRequest_GetResponseHeaders_m67147A5D3FF83FD75071AA42F4890439DA2092DF (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) ;
// Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JToken::DeepClone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* JToken_DeepClone_m9A8C76BD945F1D49D1778B032BE6CF75CB350A4B (JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* __this, const RuntimeMethod* method) ;
// System.Void Newtonsoft.Json.JsonSerializerSettings::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JsonSerializerSettings__ctor_mE1C9A90375BA88DF7F6911F1F96AEEC6A98CD22F (JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF* __this, const RuntimeMethod* method) ;
// System.Void Newtonsoft.Json.JsonSerializerSettings::set_DateParseHandling(Newtonsoft.Json.DateParseHandling)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JsonSerializerSettings_set_DateParseHandling_mB406892CFC183EC516945AB10AE3C8BF239A2698 (JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF* __this, int32_t ___value0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RuntimeConfig::set_origin(Unity.RemoteConfig.ConfigOrigin)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeConfig_set_origin_m6C14486843F6D9FF1EF6C632048897C7B99C6433_inline (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, int32_t ___value0, const RuntimeMethod* method) ;
// System.Void System.Nullable`1<Newtonsoft.Json.Linq.JTokenType>::.ctor(T)
inline void Nullable_1__ctor_m52AD48CA918ECAA8E53A7DE5F83CA02AF3EA544B (Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB* __this, int32_t ___value0, const RuntimeMethod* method)
{
	((  void (*) (Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB*, int32_t, const RuntimeMethod*))Nullable_1__ctor_m5100B58428BDAD8C79F3D8576B0C2E1D4F3924EB_gshared)(__this, ___value0, method);
}
// T System.Nullable`1<Newtonsoft.Json.Linq.JTokenType>::GetValueOrDefault()
inline int32_t Nullable_1_GetValueOrDefault_m7AFC352C983BBB73C8142843D7BA4ABBCDB8E67E_inline (Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB*, const RuntimeMethod*))Nullable_1_GetValueOrDefault_m26287DBB36429B2E2FBCB3F96F439248F8CAA8BB_gshared_inline)(__this, method);
}
// System.Boolean System.Nullable`1<Newtonsoft.Json.Linq.JTokenType>::get_HasValue()
inline bool Nullable_1_get_HasValue_m062422AAA723286DD6D3FDEA566B13560D01CEEE_inline (Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB*, const RuntimeMethod*))Nullable_1_get_HasValue_mB1F55188CDD50D6D725D41F55D2F2540CD15FB20_gshared_inline)(__this, method);
}
// System.Void Unity.RemoteConfig.RuntimeConfig::set_environmentId(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeConfig_set_environmentId_mF086880C01CA1AEBBE02455AE3776D5D037ADFA4_inline (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.Void Unity.RemoteConfig.RuntimeConfig::set_assignmentId(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeConfig_set_assignmentId_mD20089BCB060198D1BD6DB4C06EB3DFCCBABE510_inline (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___value0, const RuntimeMethod* method) ;
// U Newtonsoft.Json.Linq.Extensions::Value<System.Boolean>(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>)
inline bool Extensions_Value_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m1DB6D797C74FDFDDAC6548EE8EA80DD90E9430A3 (RuntimeObject* ___value0, const RuntimeMethod* method)
{
	return ((  bool (*) (RuntimeObject*, const RuntimeMethod*))Extensions_Value_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m1DB6D797C74FDFDDAC6548EE8EA80DD90E9430A3_gshared)(___value0, method);
}
// U Newtonsoft.Json.Linq.Extensions::Value<System.Single>(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>)
inline float Extensions_Value_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_mC5F3E49729A00991AFA91AC1F88BD187279B96AE (RuntimeObject* ___value0, const RuntimeMethod* method)
{
	return ((  float (*) (RuntimeObject*, const RuntimeMethod*))Extensions_Value_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_mC5F3E49729A00991AFA91AC1F88BD187279B96AE_gshared)(___value0, method);
}
// U Newtonsoft.Json.Linq.Extensions::Value<System.Int32>(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>)
inline int32_t Extensions_Value_TisInt32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_m3092267C93448D476CE9F21D518B204704D234B8 (RuntimeObject* ___value0, const RuntimeMethod* method)
{
	return ((  int32_t (*) (RuntimeObject*, const RuntimeMethod*))Extensions_Value_TisInt32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_m3092267C93448D476CE9F21D518B204704D234B8_gshared)(___value0, method);
}
// U Newtonsoft.Json.Linq.Extensions::Value<System.String>(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>)
inline String_t* Extensions_Value_TisString_t_m2497E7CEFECAA73AFA2AC29B672F29E6489E1D30 (RuntimeObject* ___value0, const RuntimeMethod* method)
{
	return ((  String_t* (*) (RuntimeObject*, const RuntimeMethod*))Extensions_Value_TisRuntimeObject_mAF6EBA58652B6AD49FA0ABA70115C4B422647464_gshared)(___value0, method);
}
// System.Boolean System.DateTime::TryParse(System.String,System.DateTime&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool DateTime_TryParse_m6131FF17CA7636FC1F7C48DE1D4C99AB4E961E34 (String_t* ___s0, DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D* ___result1, const RuntimeMethod* method) ;
// System.String Newtonsoft.Json.JsonConvert::SerializeObject(System.Object,Newtonsoft.Json.JsonSerializerSettings)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* JsonConvert_SerializeObject_m39CAEEF10A134A4A5A39B4A515782CD59B267459 (RuntimeObject* ___value0, JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF* ___settings1, const RuntimeMethod* method) ;
// System.String System.String::Replace(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166 (String_t* __this, String_t* ___oldValue0, String_t* ___newValue1, const RuntimeMethod* method) ;
// U Newtonsoft.Json.Linq.Extensions::Value<System.Int64>(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>)
inline int64_t Extensions_Value_TisInt64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_m6F4AADD3516AF69D3B4211A1CE328B7DE1F17145 (RuntimeObject* ___value0, const RuntimeMethod* method)
{
	return ((  int64_t (*) (RuntimeObject*, const RuntimeMethod*))Extensions_Value_TisInt64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_m6F4AADD3516AF69D3B4211A1CE328B7DE1F17145_gshared)(___value0, method);
}
// System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JProperty> Newtonsoft.Json.Linq.JObject::Properties()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* JObject_Properties_mC40EABB282AF596A0730D5D0EA3E6A584C2FBC2A (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* __this, const RuntimeMethod* method) ;
// System.Void System.Func`2<Newtonsoft.Json.Linq.JProperty,System.String>::.ctor(System.Object,System.IntPtr)
inline void Func_2__ctor_mB93DBC8D0BDC9C65A0227565BE84A583D35EBBE3 (Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879*, RuntimeObject*, intptr_t, const RuntimeMethod*))Func_2__ctor_m7F8A01C0B02BC1D4063F4EB1E817F7A48562A398_gshared)(__this, ___object0, ___method1, method);
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select<Newtonsoft.Json.Linq.JProperty,System.String>(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
inline RuntimeObject* Enumerable_Select_TisJProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4_TisString_t_m928103D228A7FFCA8F8751874BA290AB9FD067B3 (RuntimeObject* ___source0, Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879* ___selector1, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (RuntimeObject*, Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879*, const RuntimeMethod*))Enumerable_Select_TisRuntimeObject_TisRuntimeObject_m960CFE6ABFCB6C2399B69DEDFB27765D1FCE57A6_gshared)(___source0, ___selector1, method);
}
// TSource[] System.Linq.Enumerable::ToArray<System.String>(System.Collections.Generic.IEnumerable`1<TSource>)
inline StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* Enumerable_ToArray_TisString_t_mCD2BC789CBFF834E06F00948FC47E15E720936DC (RuntimeObject* ___source0, const RuntimeMethod* method)
{
	return ((  StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* (*) (RuntimeObject*, const RuntimeMethod*))Enumerable_ToArray_TisRuntimeObject_m6B1F26FB2B3EA7B18B82FC81035440AAAEFCE924_gshared)(___source0, method);
}
// System.Void Unity.RemoteConfig.RuntimeConfig/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m055552C37E5ECFA5A898DE4DE579920B133EAD34 (U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9* __this, const RuntimeMethod* method) ;
// System.String Newtonsoft.Json.Linq.JProperty::get_Name()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* JProperty_get_Name_m96280838000C5E193121125A503BA9108DB707CA_inline (JProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4* __this, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Unity.RemoteConfig.ConfigRequestStatus Unity.RemoteConfig.ConfigManager::get_requestStatus()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ConfigManager_get_requestStatus_m0278F830905337EC0203B2D6A98F30F325867CDE (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// get { return ConfigManagerImpl.appConfig.RequestStatus; }
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		NullCheck(L_0);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_1;
		L_1 = ConfigManagerImpl_get_appConfig_mD4AEBB6B75C89BD51F4150114F1464F6E019DE8A(L_0, NULL);
		NullCheck(L_1);
		int32_t L_2 = L_1->___RequestStatus_5;
		return L_2;
	}
}
// System.Void Unity.RemoteConfig.ConfigManager::set_requestStatus(Unity.RemoteConfig.ConfigRequestStatus)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManager_set_requestStatus_m56FE7BC7C9EADAB175BFAC2FD69C7931F3575238 (int32_t ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// set { ConfigManagerImpl.appConfig.RequestStatus = value; }
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		NullCheck(L_0);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_1;
		L_1 = ConfigManagerImpl_get_appConfig_mD4AEBB6B75C89BD51F4150114F1464F6E019DE8A(L_0, NULL);
		int32_t L_2 = ___value0;
		NullCheck(L_1);
		L_1->___RequestStatus_5 = L_2;
		// set { ConfigManagerImpl.appConfig.RequestStatus = value; }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManager::add_FetchCompleted(System.Action`1<Unity.RemoteConfig.ConfigResponse>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManager_add_FetchCompleted_m97A9238D5918FF6017590F41CE1AC490D804F417 (Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// add { ConfigManagerImpl.appConfig.FetchCompleted += value; }
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		NullCheck(L_0);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_1;
		L_1 = ConfigManagerImpl_get_appConfig_mD4AEBB6B75C89BD51F4150114F1464F6E019DE8A(L_0, NULL);
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_2 = ___value0;
		NullCheck(L_1);
		RuntimeConfig_add_FetchCompleted_mFDD787BA362A46B3C2CC3ED5B93D2007FC3C7338(L_1, L_2, NULL);
		// add { ConfigManagerImpl.appConfig.FetchCompleted += value; }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManager::remove_FetchCompleted(System.Action`1<Unity.RemoteConfig.ConfigResponse>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManager_remove_FetchCompleted_mC87B2EAC3C6772192ABF22303FF3022205F55A79 (Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// remove { ConfigManagerImpl.appConfig.FetchCompleted -= value; }
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		NullCheck(L_0);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_1;
		L_1 = ConfigManagerImpl_get_appConfig_mD4AEBB6B75C89BD51F4150114F1464F6E019DE8A(L_0, NULL);
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_2 = ___value0;
		NullCheck(L_1);
		RuntimeConfig_remove_FetchCompleted_m193774BB24681096DF02973B7F5F5B6A024F01AB(L_1, L_2, NULL);
		// remove { ConfigManagerImpl.appConfig.FetchCompleted -= value; }
		return;
	}
}
// Unity.RemoteConfig.RuntimeConfig Unity.RemoteConfig.ConfigManager::get_appConfig()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* ConfigManager_get_appConfig_mC437065E008A443BA1A7DA26B664F9240EB2C551 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// get { return ConfigManagerImpl.appConfig; }
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		NullCheck(L_0);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_1;
		L_1 = ConfigManagerImpl_get_appConfig_mD4AEBB6B75C89BD51F4150114F1464F6E019DE8A(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.ConfigManager::set_appConfig(Unity.RemoteConfig.RuntimeConfig)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManager_set_appConfig_m05B250914069249C51164FE753C99F624426B656 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// set { ConfigManagerImpl.appConfig = value; }
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_1 = ___value0;
		NullCheck(L_0);
		ConfigManagerImpl_set_appConfig_m48FADB6A02666D6EE5AE014D98A88B2630AAEC0C(L_0, L_1, NULL);
		// set { ConfigManagerImpl.appConfig = value; }
		return;
	}
}
// Unity.RemoteConfig.RuntimeConfig Unity.RemoteConfig.ConfigManager::GetConfig(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* ConfigManager_GetConfig_mB2496F98B6B17998C631BDA0ED04DD02B709D750 (String_t* ___configType0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return ConfigManagerImpl.GetConfig(configType);
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		String_t* L_1 = ___configType0;
		NullCheck(L_0);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_2;
		L_2 = ConfigManagerImpl_GetConfig_m98D77B1A47BAF896EC6AB0B94E08AEEA0AFDD9DA(L_0, L_1, NULL);
		return L_2;
	}
}
// System.Void Unity.RemoteConfig.ConfigManager::SetCustomUserID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManager_SetCustomUserID_mECF4182DDE03E0F5D2CE3555FB4D15631576F7C6 (String_t* ___customUserID0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// ConfigManagerImpl.SetCustomUserID(customUserID);
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		String_t* L_1 = ___customUserID0;
		NullCheck(L_0);
		ConfigManagerImpl_SetCustomUserID_m8FF642427B5C2302557A7B622BC567CDEDF767F3(L_0, L_1, NULL);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManager::SetEnvironmentID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManager_SetEnvironmentID_mA2E3A1DF6C9A56D85EAC19C65B6072075F63C19E (String_t* ___environmentID0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// ConfigManagerImpl.SetEnvironmentID(environmentID);
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		String_t* L_1 = ___environmentID0;
		NullCheck(L_0);
		ConfigManagerImpl_SetEnvironmentID_m1F29BFE714C5F7DCF688F3713BFB5A1A098B114A(L_0, L_1, NULL);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManager::SetPlayerIdentityToken(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManager_SetPlayerIdentityToken_m9D5803EA3D1DAC5F202012D837D357A06F0977B4 (String_t* ___playerIdentityToken0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// ConfigManagerImpl.SetPlayerIdentityToken(playerIdentityToken);
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		String_t* L_1 = ___playerIdentityToken0;
		NullCheck(L_0);
		ConfigManagerImpl_SetPlayerIdentityToken_m8485CA0DD7AE0E95B8FF3B8BCB08A62A0446A1B2_inline(L_0, L_1, NULL);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManager::SaveCache(Unity.RemoteConfig.ConfigOrigin,System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManager_SaveCache_mD18EA467C8FB61A74E349CA893C7F944031363D9 (int32_t ___origin0, Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___headers1, String_t* ___result2, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// var configResponse = ConfigManagerImpl.ParseResponse(origin, headers, result);
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		int32_t L_1 = ___origin0;
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_2 = ___headers1;
		String_t* L_3 = ___result2;
		NullCheck(L_0);
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_4;
		L_4 = ConfigManagerImpl_ParseResponse_m66ADE9C6AE574604ADA656D2233F8DE1F51DE897(L_0, L_1, L_2, L_3, NULL);
		V_0 = L_4;
		// ConfigManagerImpl.SaveCache(configResponse);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_5 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_6 = V_0;
		NullCheck(L_5);
		ConfigManagerImpl_SaveCache_m43661F9802E18D7B3BDE3E372AF46D72E08FB5E4(L_5, L_6, NULL);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManager::LoadFromCache()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManager_LoadFromCache_m0DD2B95C4645E70300E429E8008F9C440C629F4E (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// ConfigManagerImpl.LoadFromCache();
		il2cpp_codegen_runtime_class_init_inline(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = ((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0;
		NullCheck(L_0);
		ConfigManagerImpl_LoadFromCache_m308A9C3C2867E19A7348741D3BF09EBCAAE4D156(L_0, NULL);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManager::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManager__cctor_mCC3E404CC1E0F37C2492DB3E00EE9938141A9775 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD3E1BCEB702885F4CBCAF83976FF64FEF7A55EE3);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFEA0D25AE1D3DDABAAE8CE7E329A0911AB161618);
		s_Il2CppMethodInitialized = true;
	}
	{
		// internal static ConfigManagerImpl ConfigManagerImpl = new ConfigManagerImpl("remote-config");
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_0 = (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7*)il2cpp_codegen_object_new(ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		ConfigManagerImpl__ctor_m27834170D98EA71F6599F1170A361259240FF178(L_0, _stringLiteralFEA0D25AE1D3DDABAAE8CE7E329A0911AB161618, _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, _stringLiteralD3E1BCEB702885F4CBCAF83976FF64FEF7A55EE3, NULL);
		((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_StaticFields*)il2cpp_codegen_static_fields_for(ConfigManager_t404383915D02AFCC44EB88B5E76D2B27FE865171_il2cpp_TypeInfo_var))->___ConfigManagerImpl_0), (void*)L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Unity.RemoteConfig.RuntimeConfig Unity.RemoteConfig.ConfigManagerImpl::get_appConfig()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* ConfigManagerImpl_get_appConfig_mD4AEBB6B75C89BD51F4150114F1464F6E019DE8A (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return configs.ContainsKey(DefaultConfigKey) ? configs[DefaultConfigKey] : null;
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_0 = __this->___configs_2;
		NullCheck(L_0);
		bool L_1;
		L_1 = Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1(L_0, _stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2, Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1_RuntimeMethod_var);
		if (L_1)
		{
			goto IL_0014;
		}
	}
	{
		return (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99*)NULL;
	}

IL_0014:
	{
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_2 = __this->___configs_2;
		NullCheck(L_2);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_3;
		L_3 = Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5(L_2, _stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2, Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		return L_3;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::set_appConfig(Unity.RemoteConfig.RuntimeConfig)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_set_appConfig_m48FADB6A02666D6EE5AE014D98A88B2630AAEC0C (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (value != null)
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_0 = ___value0;
		if (!L_0)
		{
			goto IL_0014;
		}
	}
	{
		// configs[DefaultConfigKey] = value;
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_1 = __this->___configs_2;
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_2 = ___value0;
		NullCheck(L_1);
		Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842(L_1, _stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2, L_2, Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var);
	}

IL_0014:
	{
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::add_FetchCompleted(System.Action`1<Unity.RemoteConfig.ConfigResponse>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_add_FetchCompleted_mF6B19CF75E17DC81214E790E96952CBED147163E (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_0 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_1 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_2 = NULL;
	{
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_0 = __this->___FetchCompleted_13;
		V_0 = L_0;
	}

IL_0007:
	{
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_1 = V_0;
		V_1 = L_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_2 = V_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_3 = ___value0;
		Delegate_t* L_4;
		L_4 = Delegate_Combine_m8B9D24CED35033C7FC56501DFE650F5CB7FF012C(L_2, L_3, NULL);
		V_2 = ((Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)Castclass((RuntimeObject*)L_4, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var));
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E** L_5 = (&__this->___FetchCompleted_13);
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_6 = V_2;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_7 = V_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_8;
		L_8 = InterlockedCompareExchangeImpl<Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*>(L_5, L_6, L_7);
		V_0 = L_8;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_9 = V_0;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_10 = V_1;
		if ((!(((RuntimeObject*)(Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)L_9) == ((RuntimeObject*)(Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::remove_FetchCompleted(System.Action`1<Unity.RemoteConfig.ConfigResponse>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_remove_FetchCompleted_mD63D7D50ADB86CEFB3BDFFBADB9DF265DCCB3C5A (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_0 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_1 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_2 = NULL;
	{
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_0 = __this->___FetchCompleted_13;
		V_0 = L_0;
	}

IL_0007:
	{
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_1 = V_0;
		V_1 = L_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_2 = V_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_3 = ___value0;
		Delegate_t* L_4;
		L_4 = Delegate_Remove_m40506877934EC1AD4ADAE57F5E97AF0BC0F96116(L_2, L_3, NULL);
		V_2 = ((Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)Castclass((RuntimeObject*)L_4, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var));
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E** L_5 = (&__this->___FetchCompleted_13);
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_6 = V_2;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_7 = V_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_8;
		L_8 = InterlockedCompareExchangeImpl<Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*>(L_5, L_6, L_7);
		V_0 = L_8;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_9 = V_0;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_10 = V_1;
		if ((!(((RuntimeObject*)(Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)L_9) == ((RuntimeObject*)(Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::.ctor(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl__ctor_m27834170D98EA71F6599F1170A361259240FF178 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___originService0, String_t* ___attributionMetadataStr1, String_t* ___cacheFileRC2, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManagerImpl_SaveCache_m43661F9802E18D7B3BDE3E372AF46D72E08FB5E4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_m472ECA9A0B49BFD1553C6AFB1B926F2A9DC8E07B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m5F52BEE935E79774B7BEB5DF51F0AA696A0598C6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mA28F18D77CFE93EBCAC6BD896325683999D261FD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t0829E916C4AAB917E57526AEED3AB682DB994946_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5F10B8B394D955D4DDBF1EDA2398E483B471C117);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815 V_0;
	memset((&V_0), 0, sizeof(V_0));
	Exception_t* V_1 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	Exception_t* G_B4_0 = NULL;
	String_t* G_B4_1 = NULL;
	String_t* G_B4_2 = NULL;
	String_t* G_B4_3 = NULL;
	Exception_t* G_B3_0 = NULL;
	String_t* G_B3_1 = NULL;
	String_t* G_B3_2 = NULL;
	String_t* G_B3_3 = NULL;
	String_t* G_B5_0 = NULL;
	String_t* G_B5_1 = NULL;
	String_t* G_B5_2 = NULL;
	String_t* G_B5_3 = NULL;
	{
		// internal List<Func<RequestHeaderTuple>> requestHeaderProviders = new List<Func<RequestHeaderTuple>>();
		List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C* L_0 = (List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C*)il2cpp_codegen_object_new(List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		List_1__ctor_mA28F18D77CFE93EBCAC6BD896325683999D261FD(L_0, List_1__ctor_mA28F18D77CFE93EBCAC6BD896325683999D261FD_RuntimeMethod_var);
		__this->___requestHeaderProviders_6 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___requestHeaderProviders_6), (void*)L_0);
		// internal List<Func<Dictionary<string, string>, string, bool>> rawResponseValidators = new List<Func<Dictionary<string, string>, string, bool>>();
		List_1_t0829E916C4AAB917E57526AEED3AB682DB994946* L_1 = (List_1_t0829E916C4AAB917E57526AEED3AB682DB994946*)il2cpp_codegen_object_new(List_1_t0829E916C4AAB917E57526AEED3AB682DB994946_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		List_1__ctor_m5F52BEE935E79774B7BEB5DF51F0AA696A0598C6(L_1, List_1__ctor_m5F52BEE935E79774B7BEB5DF51F0AA696A0598C6_RuntimeMethod_var);
		__this->___rawResponseValidators_7 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___rawResponseValidators_7), (void*)L_1);
		// public ConfigManagerImpl(string originService, string attributionMetadataStr = "", string cacheFileRC = DefaultCacheFile)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// configs = new Dictionary<string, RuntimeConfig>();
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_2 = (Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D*)il2cpp_codegen_object_new(Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		Dictionary_2__ctor_m472ECA9A0B49BFD1553C6AFB1B926F2A9DC8E07B(L_2, Dictionary_2__ctor_m472ECA9A0B49BFD1553C6AFB1B926F2A9DC8E07B_RuntimeMethod_var);
		__this->___configs_2 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___configs_2), (void*)L_2);
		// cacheFile = cacheFileRC;
		String_t* L_3 = ___cacheFileRC2;
		__this->___cacheFile_8 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___cacheFile_8), (void*)L_3);
		// appConfig = new RuntimeConfig("settings");
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_4 = (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99*)il2cpp_codegen_object_new(RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var);
		NullCheck(L_4);
		RuntimeConfig__ctor_m86B59B69E6F3D781991235921A872D8362417EF7(L_4, _stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2, NULL);
		ConfigManagerImpl_set_appConfig_m48FADB6A02666D6EE5AE014D98A88B2630AAEC0C(__this, L_4, NULL);
		//             _remoteConfigRequest = new RemoteConfigRequest
		//             {
		// #if !UNITY_SWITCH && !UNITY_PS4 && !UNITY_PS5 && !UNITY_XBOXONE
		//                 projectId = Application.cloudProjectId,
		//                 userId = AnalyticsSessionInfo.userId,
		// #endif
		//                 isDebugBuild = Debug.isDebugBuild,
		//                 configType = "",
		//                 packageVersion = pluginVersion + "+RCR",
		//                 originService = originService,
		//             };
		il2cpp_codegen_initobj((&V_0), sizeof(RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815));
		String_t* L_5;
		L_5 = Application_get_cloudProjectId_mC4A9551019BB135B39D816F55A912CC2E9858F84(NULL);
		(&V_0)->___projectId_0 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&(&V_0)->___projectId_0), (void*)L_5);
		String_t* L_6;
		L_6 = AnalyticsSessionInfo_get_userId_mA331343A74FF5FB69F0478CCA03FE4872A3BA3D1(NULL);
		(&V_0)->___userId_1 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&(&V_0)->___userId_1), (void*)L_6);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		bool L_7;
		L_7 = Debug_get_isDebugBuild_mD757482E7E84FD089E874DD0778A5200D12C14E0(NULL);
		(&V_0)->___isDebugBuild_2 = L_7;
		(&V_0)->___configType_3 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		Il2CppCodeGenWriteBarrier((void**)(&(&V_0)->___configType_3), (void*)_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		(&V_0)->___packageVersion_9 = _stringLiteral5F10B8B394D955D4DDBF1EDA2398E483B471C117;
		Il2CppCodeGenWriteBarrier((void**)(&(&V_0)->___packageVersion_9), (void*)_stringLiteral5F10B8B394D955D4DDBF1EDA2398E483B471C117);
		String_t* L_8 = ___originService0;
		(&V_0)->___originService_10 = L_8;
		Il2CppCodeGenWriteBarrier((void**)(&(&V_0)->___originService_10), (void*)L_8);
		RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815 L_9 = V_0;
		__this->____remoteConfigRequest_4 = L_9;
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___projectId_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___userId_1), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___configType_3), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___key_4), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___type_5), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___schemaId_6), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___customUserId_7), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___environmentId_8), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___packageVersion_9), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___originService_10), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->____remoteConfigRequest_4))->___attributionMetadata_11), (void*)NULL);
		#endif
		// if (!string.IsNullOrEmpty(attributionMetadataStr))
		String_t* L_10 = ___attributionMetadataStr1;
		bool L_11;
		L_11 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_10, NULL);
		if (L_11)
		{
			goto IL_00d1;
		}
	}
	try
	{// begin try (depth: 1)
		// _remoteConfigRequest.attributionMetadata = JObject.Parse(attributionMetadataStr);
		RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815* L_12 = (&__this->____remoteConfigRequest_4);
		String_t* L_13 = ___attributionMetadataStr1;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_14;
		L_14 = JObject_Parse_mAFE39B83D08F5D889D34F83E017661FF28E4D0AC(L_13, NULL);
		L_12->___attributionMetadata_11 = L_14;
		Il2CppCodeGenWriteBarrier((void**)(&L_12->___attributionMetadata_11), (void*)L_14);
		// }
		goto IL_00d1;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_00ac;
		}
		throw e;
	}

CATCH_00ac:
	{// begin catch(System.Exception)
		{
			// catch (Exception e)
			V_1 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
			// Debug.LogWarning("attributionMetadata is not valid JSON:\n" + attributionMetadataStr + "\n" + e);
			String_t* L_15 = ___attributionMetadataStr1;
			Exception_t* L_16 = V_1;
			Exception_t* L_17 = L_16;
			G_B3_0 = L_17;
			G_B3_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD));
			G_B3_2 = L_15;
			G_B3_3 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralC8BD3DCAB0097617B6017163139B4704213A67EF));
			if (L_17)
			{
				G_B4_0 = L_17;
				G_B4_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD));
				G_B4_2 = L_15;
				G_B4_3 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralC8BD3DCAB0097617B6017163139B4704213A67EF));
				goto IL_00c0;
			}
		}
		{
			G_B5_0 = ((String_t*)(NULL));
			G_B5_1 = G_B3_1;
			G_B5_2 = G_B3_2;
			G_B5_3 = G_B3_3;
			goto IL_00c5;
		}

IL_00c0:
		{
			NullCheck(G_B4_0);
			String_t* L_18;
			L_18 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B4_0);
			G_B5_0 = L_18;
			G_B5_1 = G_B4_1;
			G_B5_2 = G_B4_2;
			G_B5_3 = G_B4_3;
		}

IL_00c5:
		{
			String_t* L_19;
			L_19 = String_Concat_mF8B69BE42B5C5ABCAD3C176FBBE3010E0815D65D(G_B5_3, G_B5_2, G_B5_1, G_B5_0, NULL);
			il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var)));
			Debug_LogWarning_mEF15C6B17CE4E1FA7E379CDB82CE40FCD89A3F28(L_19, NULL);
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_00d1;
		}
	}// end catch (depth: 1)

IL_00d1:
	{
		// _unityAttributes = new UnityAttributes();
		UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04* L_20 = (UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04*)il2cpp_codegen_object_new(UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04_il2cpp_TypeInfo_var);
		NullCheck(L_20);
		UnityAttributes__ctor_mD96F9FE53FA0BF66C1E0BA6775522D429011742E(L_20, NULL);
		__this->____unityAttributes_5 = L_20;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____unityAttributes_5), (void*)L_20);
		// FetchCompleted += SaveCache;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_21 = (Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)il2cpp_codegen_object_new(Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var);
		NullCheck(L_21);
		Action_1__ctor_m77852814147BA0498380271637D56B354BC79167(L_21, __this, (intptr_t)((void*)ConfigManagerImpl_SaveCache_m43661F9802E18D7B3BDE3E372AF46D72E08FB5E4_RuntimeMethod_var), NULL);
		ConfigManagerImpl_add_FetchCompleted_mF6B19CF75E17DC81214E790E96952CBED147163E(__this, L_21, NULL);
		// LoadFromCache();
		ConfigManagerImpl_LoadFromCache_m308A9C3C2867E19A7348741D3BF09EBCAAE4D156(__this, NULL);
		// }
		return;
	}
}
// Unity.RemoteConfig.ConfigResponse Unity.RemoteConfig.ConfigManagerImpl::ParseResponse(Unity.RemoteConfig.ConfigOrigin,System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ConfigManagerImpl_ParseResponse_m66ADE9C6AE574604ADA656D2233F8DE1F51DE897 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, int32_t ___origin0, Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___headers1, String_t* ___body2, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m1DEFE09EF1D0A3CE3C51A4A06C471B5A272939FE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m0CDA887E6760543D0ABE8722B4DE088D49F87F85_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_mC9EFE54C2C30BA46A2066277788398580C887257_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_GetEnumerator_m3465F03E8555CE28FCA9069FE1CD237725DF45F2_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 V_0;
	memset((&V_0), 0, sizeof(V_0));
	ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 V_1;
	memset((&V_1), 0, sizeof(V_1));
	Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803 V_2;
	memset((&V_2), 0, sizeof(V_2));
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* V_3 = NULL;
	Exception_t* V_4 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* G_B14_0 = NULL;
	String_t* G_B14_1 = NULL;
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* G_B13_0 = NULL;
	String_t* G_B13_1 = NULL;
	String_t* G_B15_0 = NULL;
	String_t* G_B15_1 = NULL;
	Exception_t* G_B17_0 = NULL;
	String_t* G_B17_1 = NULL;
	String_t* G_B17_2 = NULL;
	String_t* G_B17_3 = NULL;
	Exception_t* G_B16_0 = NULL;
	String_t* G_B16_1 = NULL;
	String_t* G_B16_2 = NULL;
	String_t* G_B16_3 = NULL;
	String_t* G_B18_0 = NULL;
	String_t* G_B18_1 = NULL;
	String_t* G_B18_2 = NULL;
	String_t* G_B18_3 = NULL;
	{
		// var configResponse = new ConfigResponse {
		//     requestOrigin = origin,
		//     headers = headers
		// };
		il2cpp_codegen_initobj((&V_1), sizeof(ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871));
		int32_t L_0 = ___origin0;
		(&V_1)->___requestOrigin_0 = L_0;
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_1 = ___headers1;
		(&V_1)->___headers_3 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&(&V_1)->___headers_3), (void*)L_1);
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_2 = V_1;
		V_0 = L_2;
		// if(body == null || headers == null)
		String_t* L_3 = ___body2;
		if (!L_3)
		{
			goto IL_0020;
		}
	}
	{
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_4 = ___headers1;
		if (L_4)
		{
			goto IL_002a;
		}
	}

IL_0020:
	{
		// configResponse.status = ConfigRequestStatus.Failed;
		(&V_0)->___status_1 = 1;
		// return configResponse;
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_5 = V_0;
		return L_5;
	}

IL_002a:
	{
		// foreach (var validationFunc in rawResponseValidators)
		List_1_t0829E916C4AAB917E57526AEED3AB682DB994946* L_6 = __this->___rawResponseValidators_7;
		NullCheck(L_6);
		Enumerator_tFFEB0694EBFF03A824035D0BFC61E0BFFF459803 L_7;
		L_7 = List_1_GetEnumerator_m3465F03E8555CE28FCA9069FE1CD237725DF45F2(L_6, List_1_GetEnumerator_m3465F03E8555CE28FCA9069FE1CD237725DF45F2_RuntimeMethod_var);
		V_2 = L_7;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_005f:
			{// begin finally (depth: 1)
				Enumerator_Dispose_m1DEFE09EF1D0A3CE3C51A4A06C471B5A272939FE((&V_2), Enumerator_Dispose_m1DEFE09EF1D0A3CE3C51A4A06C471B5A272939FE_RuntimeMethod_var);
				return;
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_0054_1;
			}

IL_0038_1:
			{
				// foreach (var validationFunc in rawResponseValidators)
				Func_3_t6491300EDE89815C2EE58365B51E0AE133B267AD* L_8;
				L_8 = Enumerator_get_Current_mC9EFE54C2C30BA46A2066277788398580C887257_inline((&V_2), Enumerator_get_Current_mC9EFE54C2C30BA46A2066277788398580C887257_RuntimeMethod_var);
				// if(validationFunc(headers, body) == false)
				Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_9 = ___headers1;
				String_t* L_10 = ___body2;
				NullCheck(L_8);
				bool L_11;
				L_11 = Func_3_Invoke_m4BC1396C95F81B081501D01E5109A00A49631968_inline(L_8, L_9, L_10, NULL);
				if (L_11)
				{
					goto IL_0054_1;
				}
			}
			{
				// configResponse.status = ConfigRequestStatus.Failed;
				(&V_0)->___status_1 = 1;
				// return configResponse;
				ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_12 = V_0;
				V_1 = L_12;
				goto IL_00c9;
			}

IL_0054_1:
			{
				// foreach (var validationFunc in rawResponseValidators)
				bool L_13;
				L_13 = Enumerator_MoveNext_m0CDA887E6760543D0ABE8722B4DE088D49F87F85((&V_2), Enumerator_MoveNext_m0CDA887E6760543D0ABE8722B4DE088D49F87F85_RuntimeMethod_var);
				if (L_13)
				{
					goto IL_0038_1;
				}
			}
			{
				goto IL_006d;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_006d:
	{
	}
	try
	{// begin try (depth: 1)
		// var responseJObj = JObject.Parse(body);
		String_t* L_14 = ___body2;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_15;
		L_15 = JObject_Parse_mAFE39B83D08F5D889D34F83E017661FF28E4D0AC(L_14, NULL);
		V_3 = L_15;
		// configResponse.body = responseJObj;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_16 = V_3;
		(&V_0)->___body_2 = L_16;
		Il2CppCodeGenWriteBarrier((void**)(&(&V_0)->___body_2), (void*)L_16);
		// configResponse.status = ConfigRequestStatus.Success;
		(&V_0)->___status_1 = 2;
		// }
		goto IL_00c7;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0087;
		}
		throw e;
	}

CATCH_0087:
	{// begin catch(System.Exception)
		{
			// catch (Exception e)
			V_4 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
			// Debug.LogWarning("config response is not valid JSON:\n" + configResponse.body + "\n" + e);
			ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_17 = V_0;
			JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_18 = L_17.___body_2;
			JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_19 = L_18;
			G_B13_0 = L_19;
			G_B13_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral2D39827A7835A83EF049D5A7A806C2C7C6EC42FA));
			if (L_19)
			{
				G_B14_0 = L_19;
				G_B14_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral2D39827A7835A83EF049D5A7A806C2C7C6EC42FA));
				goto IL_009b;
			}
		}
		{
			G_B15_0 = ((String_t*)(NULL));
			G_B15_1 = G_B13_1;
			goto IL_00a0;
		}

IL_009b:
		{
			NullCheck(G_B14_0);
			String_t* L_20;
			L_20 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B14_0);
			G_B15_0 = L_20;
			G_B15_1 = G_B14_1;
		}

IL_00a0:
		{
			Exception_t* L_21 = V_4;
			Exception_t* L_22 = L_21;
			G_B16_0 = L_22;
			G_B16_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD));
			G_B16_2 = G_B15_0;
			G_B16_3 = G_B15_1;
			if (L_22)
			{
				G_B17_0 = L_22;
				G_B17_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD));
				G_B17_2 = G_B15_0;
				G_B17_3 = G_B15_1;
				goto IL_00ae;
			}
		}
		{
			G_B18_0 = ((String_t*)(NULL));
			G_B18_1 = G_B16_1;
			G_B18_2 = G_B16_2;
			G_B18_3 = G_B16_3;
			goto IL_00b3;
		}

IL_00ae:
		{
			NullCheck(G_B17_0);
			String_t* L_23;
			L_23 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B17_0);
			G_B18_0 = L_23;
			G_B18_1 = G_B17_1;
			G_B18_2 = G_B17_2;
			G_B18_3 = G_B17_3;
		}

IL_00b3:
		{
			String_t* L_24;
			L_24 = String_Concat_mF8B69BE42B5C5ABCAD3C176FBBE3010E0815D65D(G_B18_3, G_B18_2, G_B18_1, G_B18_0, NULL);
			il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var)));
			Debug_LogWarning_mEF15C6B17CE4E1FA7E379CDB82CE40FCD89A3F28(L_24, NULL);
			// configResponse.status = ConfigRequestStatus.Failed;
			(&V_0)->___status_1 = 1;
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_00c7;
		}
	}// end catch (depth: 1)

IL_00c7:
	{
		// return configResponse;
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_25 = V_0;
		return L_25;
	}

IL_00c9:
	{
		// }
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_26 = V_1;
		return L_26;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::SetCustomUserID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_SetCustomUserID_m8FF642427B5C2302557A7B622BC567CDEDF767F3 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___customUserID0, const RuntimeMethod* method) 
{
	{
		// _remoteConfigRequest.customUserId = customUserID;
		RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815* L_0 = (&__this->____remoteConfigRequest_4);
		String_t* L_1 = ___customUserID0;
		L_0->___customUserId_7 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&L_0->___customUserId_7), (void*)L_1);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::SetEnvironmentID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_SetEnvironmentID_m1F29BFE714C5F7DCF688F3713BFB5A1A098B114A (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___environmentID0, const RuntimeMethod* method) 
{
	{
		// _remoteConfigRequest.environmentId = environmentID;
		RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815* L_0 = (&__this->____remoteConfigRequest_4);
		String_t* L_1 = ___environmentID0;
		L_0->___environmentId_8 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&L_0->___environmentId_8), (void*)L_1);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::SetPlayerIdentityToken(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_SetPlayerIdentityToken_m8485CA0DD7AE0E95B8FF3B8BCB08A62A0446A1B2 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___identityToken0, const RuntimeMethod* method) 
{
	{
		// _playerIdentityToken = identityToken;
		String_t* L_0 = ___identityToken0;
		__this->____playerIdentityToken_3 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____playerIdentityToken_3), (void*)L_0);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::FetchConfigs(System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_FetchConfigs_mD20AB971A7A5E76F0D0E778C65AE2FC38E64FF8F (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, RuntimeObject* ___userAttributes0, RuntimeObject* ___appAttributes1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2);
		s_Il2CppMethodInitialized = true;
	}
	{
		// PostConfigWithConfigType("settings", userAttributes, appAttributes);
		RuntimeObject* L_0 = ___userAttributes0;
		RuntimeObject* L_1 = ___appAttributes1;
		ConfigManagerImpl_PostConfigWithConfigType_m339D300603127623CA9B42D34FE1CC32C25CE4CA(__this, _stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2, L_0, L_1, NULL, NULL);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::FetchConfigs(System.Object,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_FetchConfigs_m5E613D716665B2D0654AAFC1583103C5C6AE6941 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, RuntimeObject* ___userAttributes0, RuntimeObject* ___appAttributes1, RuntimeObject* ___filterAttributes2, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2);
		s_Il2CppMethodInitialized = true;
	}
	{
		// PostConfigWithConfigType("settings", userAttributes, appAttributes, filterAttributes);
		RuntimeObject* L_0 = ___userAttributes0;
		RuntimeObject* L_1 = ___appAttributes1;
		RuntimeObject* L_2 = ___filterAttributes2;
		ConfigManagerImpl_PostConfigWithConfigType_m339D300603127623CA9B42D34FE1CC32C25CE4CA(__this, _stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2, L_0, L_1, L_2, NULL);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::FetchConfigs(System.String,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_FetchConfigs_m5F09A6330F0FB1A58ACF2CB2F719D7427D54DB51 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, RuntimeObject* ___userAttributes1, RuntimeObject* ___appAttributes2, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (string.IsNullOrEmpty(configType))
		String_t* L_0 = ___configType0;
		bool L_1;
		L_1 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_0, NULL);
		if (!L_1)
		{
			goto IL_000f;
		}
	}
	{
		// configType = "settings";
		___configType0 = _stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2;
	}

IL_000f:
	{
		// PostConfigWithConfigType(configType, userAttributes, appAttributes);
		String_t* L_2 = ___configType0;
		RuntimeObject* L_3 = ___userAttributes1;
		RuntimeObject* L_4 = ___appAttributes2;
		ConfigManagerImpl_PostConfigWithConfigType_m339D300603127623CA9B42D34FE1CC32C25CE4CA(__this, L_2, L_3, L_4, NULL, NULL);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::FetchConfigs(System.String,System.Object,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_FetchConfigs_mEB5F8BB0FD0293F5DAD2F211892145EDBA9B25CF (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, RuntimeObject* ___userAttributes1, RuntimeObject* ___appAttributes2, RuntimeObject* ___filterAttributes3, const RuntimeMethod* method) 
{
	{
		// PostConfigWithConfigType(configType, userAttributes, appAttributes, filterAttributes);
		String_t* L_0 = ___configType0;
		RuntimeObject* L_1 = ___userAttributes1;
		RuntimeObject* L_2 = ___appAttributes2;
		RuntimeObject* L_3 = ___filterAttributes3;
		ConfigManagerImpl_PostConfigWithConfigType_m339D300603127623CA9B42D34FE1CC32C25CE4CA(__this, L_0, L_1, L_2, L_3, NULL);
		// }
		return;
	}
}
// Unity.RemoteConfig.RuntimeConfig Unity.RemoteConfig.ConfigManagerImpl::GetConfig(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* ConfigManagerImpl_GetConfig_m98D77B1A47BAF896EC6AB0B94E08AEEA0AFDD9DA (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (configs.ContainsKey(configType))
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_0 = __this->___configs_2;
		String_t* L_1 = ___configType0;
		NullCheck(L_0);
		bool L_2;
		L_2 = Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1(L_0, L_1, Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1_RuntimeMethod_var);
		if (!L_2)
		{
			goto IL_001b;
		}
	}
	{
		// return configs[configType];
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_3 = __this->___configs_2;
		String_t* L_4 = ___configType0;
		NullCheck(L_3);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_5;
		L_5 = Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5(L_3, L_4, Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		return L_5;
	}

IL_001b:
	{
		// configs[configType] = new RuntimeConfig(configType);
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_6 = __this->___configs_2;
		String_t* L_7 = ___configType0;
		String_t* L_8 = ___configType0;
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_9 = (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99*)il2cpp_codegen_object_new(RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var);
		NullCheck(L_9);
		RuntimeConfig__ctor_m86B59B69E6F3D781991235921A872D8362417EF7(L_9, L_8, NULL);
		NullCheck(L_6);
		Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842(L_6, L_7, L_9, Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var);
		// return configs[configType];
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_10 = __this->___configs_2;
		String_t* L_11 = ___configType0;
		NullCheck(L_10);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_12;
		L_12 = Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5(L_10, L_11, Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		return L_12;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::PostConfigWithConfigType(System.String,System.Object,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_PostConfigWithConfigType_m339D300603127623CA9B42D34FE1CC32C25CE4CA (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, RuntimeObject* ___userAttributes1, RuntimeObject* ___appAttributes2, RuntimeObject* ___filterAttributes3, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* V_0 = NULL;
	String_t* V_1 = NULL;
	{
		// if (string.IsNullOrEmpty(configType))
		String_t* L_0 = ___configType0;
		bool L_1;
		L_1 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_0, NULL);
		if (!L_1)
		{
			goto IL_000f;
		}
	}
	{
		// configType = "settings";
		___configType0 = _stringLiteral7DF882FBCC2A230A62D22FF65024431A34A858A2;
	}

IL_000f:
	{
		// RuntimeConfig runtimeConfig = null;
		V_0 = (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99*)NULL;
		// if (configs.ContainsKey(configType))
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_2 = __this->___configs_2;
		String_t* L_3 = ___configType0;
		NullCheck(L_2);
		bool L_4;
		L_4 = Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1(L_2, L_3, Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1_RuntimeMethod_var);
		if (!L_4)
		{
			goto IL_002c;
		}
	}
	{
		// runtimeConfig = configs[configType];
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_5 = __this->___configs_2;
		String_t* L_6 = ___configType0;
		NullCheck(L_5);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_7;
		L_7 = Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5(L_5, L_6, Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		V_0 = L_7;
	}

IL_002c:
	{
		// if (runtimeConfig == null)
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_8 = V_0;
		if (L_8)
		{
			goto IL_0043;
		}
	}
	{
		// runtimeConfig = new RuntimeConfig(configType);
		String_t* L_9 = ___configType0;
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_10 = (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99*)il2cpp_codegen_object_new(RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var);
		NullCheck(L_10);
		RuntimeConfig__ctor_m86B59B69E6F3D781991235921A872D8362417EF7(L_10, L_9, NULL);
		V_0 = L_10;
		// configs[configType] = runtimeConfig;
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_11 = __this->___configs_2;
		String_t* L_12 = ___configType0;
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_13 = V_0;
		NullCheck(L_11);
		Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842(L_11, L_12, L_13, Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var);
	}

IL_0043:
	{
		// runtimeConfig.RequestStatus = ConfigRequestStatus.Pending;
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_14 = V_0;
		NullCheck(L_14);
		L_14->___RequestStatus_5 = 3;
		// var jsonText = PreparePayloadWithConfigType(configType, userAttributes, appAttributes, filterAttributes);
		String_t* L_15 = ___configType0;
		RuntimeObject* L_16 = ___userAttributes1;
		RuntimeObject* L_17 = ___appAttributes2;
		RuntimeObject* L_18 = ___filterAttributes3;
		String_t* L_19;
		L_19 = ConfigManagerImpl_PreparePayloadWithConfigType_m552029F4263A0049E7EFA472AA12CC08CAECCF2E(__this, L_15, L_16, L_17, L_18, NULL);
		V_1 = L_19;
		// DoRequest(configType, jsonText);
		String_t* L_20 = ___configType0;
		String_t* L_21 = V_1;
		ConfigManagerImpl_DoRequest_m82B45FDFBC6F8CB5F6EA90C6673FD99F2846AEBD(__this, L_20, L_21, NULL);
		// }
		return;
	}
}
// System.String Unity.RemoteConfig.ConfigManagerImpl::PreparePayloadWithConfigType(System.String,System.Object,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ConfigManagerImpl_PreparePayloadWithConfigType_m552029F4263A0049E7EFA472AA12CC08CAECCF2E (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, RuntimeObject* ___userAttributes1, RuntimeObject* ___appAttributes2, RuntimeObject* ___filterAttributes3, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimePlatform_t9A8AAF204603076FCAAECCCC05DA386AEE7BF66E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral114BCE5E07B2B89600E7B0C1E7991AC7281CDDA6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral29AA1803EE63BE5E6E59AD64966B8601C7579987);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8AE263ACD0B994D3BE52A427E3279DE126BB0E6A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8FB5CD3CB553F7B121B1233133C592DDBD928A75);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA25C69590D313E80E32DAF839FFE871D0B53E5EB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB2F9235F4F063A8609A1E74346AC3F275A7303EE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD3992DF679A3EF8B96232992FF89A2B1F1DB5534);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE7D028CCE3B6E7B61AE2C752D7AE970DA04AB7C6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF3C6C902DBF80139640F6554F0C3392016A8ADF7);
		s_Il2CppMethodInitialized = true;
	}
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* V_0 = NULL;
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* V_1 = NULL;
	int32_t V_2 = 0;
	String_t* G_B2_0 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B2_1 = NULL;
	String_t* G_B1_0 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B1_1 = NULL;
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* G_B3_0 = NULL;
	String_t* G_B3_1 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B3_2 = NULL;
	String_t* G_B5_0 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B5_1 = NULL;
	String_t* G_B4_0 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B4_1 = NULL;
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* G_B6_0 = NULL;
	String_t* G_B6_1 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B6_2 = NULL;
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* G_B9_0 = NULL;
	{
		// var commonJobj = JObject.FromObject(_remoteConfigRequest);
		RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815 L_0 = __this->____remoteConfigRequest_4;
		RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815 L_1 = L_0;
		RuntimeObject* L_2 = Box(RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_il2cpp_TypeInfo_var, &L_1);
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_3;
		L_3 = JObject_FromObject_m5173BDC2D9FC1B112F5895863E74860550DE915B(L_2, NULL);
		V_0 = L_3;
		// commonJobj["configType"] = configType;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_4 = V_0;
		String_t* L_5 = ___configType0;
		il2cpp_codegen_runtime_class_init_inline(JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3_il2cpp_TypeInfo_var);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_6;
		L_6 = JToken_op_Implicit_mDB27F16361965B574E95F791BE9E5459EA77CC95(L_5, NULL);
		NullCheck(L_4);
		JObject_set_Item_m38ACF4BABEDE80CF0138DA900AFFC5C4CC3E9221(L_4, _stringLiteral8FB5CD3CB553F7B121B1233133C592DDBD928A75, L_6, NULL);
		// commonJobj["attributes"] = new JObject();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_7 = V_0;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_8 = (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1*)il2cpp_codegen_object_new(JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		JObject__ctor_mF7F801B6729F7309319FF97690BCC68C7CA81CE4(L_8, NULL);
		NullCheck(L_7);
		JObject_set_Item_m38ACF4BABEDE80CF0138DA900AFFC5C4CC3E9221(L_7, _stringLiteralA25C69590D313E80E32DAF839FFE871D0B53E5EB, L_8, NULL);
		// commonJobj["attributes"]["unity"] = JObject.FromObject(_unityAttributes);
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_9 = V_0;
		NullCheck(L_9);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_10;
		L_10 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_9, _stringLiteralA25C69590D313E80E32DAF839FFE871D0B53E5EB, NULL);
		UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04* L_11 = __this->____unityAttributes_5;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_12;
		L_12 = JObject_FromObject_m5173BDC2D9FC1B112F5895863E74860550DE915B(L_11, NULL);
		NullCheck(L_10);
		VirtualActionInvoker2< RuntimeObject*, JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* >::Invoke(18 /* System.Void Newtonsoft.Json.Linq.JToken::set_Item(System.Object,Newtonsoft.Json.Linq.JToken) */, L_10, _stringLiteral114BCE5E07B2B89600E7B0C1E7991AC7281CDDA6, L_12);
		// commonJobj["attributes"]["unity"]["platform"] = Application.platform.ToString();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_13 = V_0;
		NullCheck(L_13);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_14;
		L_14 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_13, _stringLiteralA25C69590D313E80E32DAF839FFE871D0B53E5EB, NULL);
		NullCheck(L_14);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_15;
		L_15 = VirtualFuncInvoker1< JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3*, RuntimeObject* >::Invoke(17 /* Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JToken::get_Item(System.Object) */, L_14, _stringLiteral114BCE5E07B2B89600E7B0C1E7991AC7281CDDA6);
		int32_t L_16;
		L_16 = Application_get_platform_m1AB34E71D9885B120F6021EB2B11DCB28CD6008D(NULL);
		V_2 = L_16;
		Il2CppFakeBox<int32_t> L_17(RuntimePlatform_t9A8AAF204603076FCAAECCCC05DA386AEE7BF66E_il2cpp_TypeInfo_var, (&V_2));
		String_t* L_18;
		L_18 = Enum_ToString_m946B0B83C4470457D0FF555D862022C72BB55741((Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2*)(&L_17), NULL);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_19;
		L_19 = JToken_op_Implicit_mDB27F16361965B574E95F791BE9E5459EA77CC95(L_18, NULL);
		NullCheck(L_15);
		VirtualActionInvoker2< RuntimeObject*, JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* >::Invoke(18 /* System.Void Newtonsoft.Json.Linq.JToken::set_Item(System.Object,Newtonsoft.Json.Linq.JToken) */, L_15, _stringLiteralB2F9235F4F063A8609A1E74346AC3F275A7303EE, L_19);
		// commonJobj["attributes"]["app"] = (appAttributes != null) ? JObject.FromObject(appAttributes) : new JObject();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_20 = V_0;
		NullCheck(L_20);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_21;
		L_21 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_20, _stringLiteralA25C69590D313E80E32DAF839FFE871D0B53E5EB, NULL);
		RuntimeObject* L_22 = ___appAttributes2;
		G_B1_0 = _stringLiteral8AE263ACD0B994D3BE52A427E3279DE126BB0E6A;
		G_B1_1 = L_21;
		if (L_22)
		{
			G_B2_0 = _stringLiteral8AE263ACD0B994D3BE52A427E3279DE126BB0E6A;
			G_B2_1 = L_21;
			goto IL_00a3;
		}
	}
	{
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_23 = (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1*)il2cpp_codegen_object_new(JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var);
		NullCheck(L_23);
		JObject__ctor_mF7F801B6729F7309319FF97690BCC68C7CA81CE4(L_23, NULL);
		G_B3_0 = L_23;
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		goto IL_00a9;
	}

IL_00a3:
	{
		RuntimeObject* L_24 = ___appAttributes2;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_25;
		L_25 = JObject_FromObject_m5173BDC2D9FC1B112F5895863E74860550DE915B(L_24, NULL);
		G_B3_0 = L_25;
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
	}

IL_00a9:
	{
		NullCheck(G_B3_2);
		VirtualActionInvoker2< RuntimeObject*, JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* >::Invoke(18 /* System.Void Newtonsoft.Json.Linq.JToken::set_Item(System.Object,Newtonsoft.Json.Linq.JToken) */, G_B3_2, G_B3_1, G_B3_0);
		// commonJobj["attributes"]["user"] = (userAttributes != null) ? JObject.FromObject(userAttributes) : new JObject();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_26 = V_0;
		NullCheck(L_26);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_27;
		L_27 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_26, _stringLiteralA25C69590D313E80E32DAF839FFE871D0B53E5EB, NULL);
		RuntimeObject* L_28 = ___userAttributes1;
		G_B4_0 = _stringLiteralD3992DF679A3EF8B96232992FF89A2B1F1DB5534;
		G_B4_1 = L_27;
		if (L_28)
		{
			G_B5_0 = _stringLiteralD3992DF679A3EF8B96232992FF89A2B1F1DB5534;
			G_B5_1 = L_27;
			goto IL_00c8;
		}
	}
	{
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_29 = (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1*)il2cpp_codegen_object_new(JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var);
		NullCheck(L_29);
		JObject__ctor_mF7F801B6729F7309319FF97690BCC68C7CA81CE4(L_29, NULL);
		G_B6_0 = L_29;
		G_B6_1 = G_B4_0;
		G_B6_2 = G_B4_1;
		goto IL_00ce;
	}

IL_00c8:
	{
		RuntimeObject* L_30 = ___userAttributes1;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_31;
		L_31 = JObject_FromObject_m5173BDC2D9FC1B112F5895863E74860550DE915B(L_30, NULL);
		G_B6_0 = L_31;
		G_B6_1 = G_B5_0;
		G_B6_2 = G_B5_1;
	}

IL_00ce:
	{
		NullCheck(G_B6_2);
		VirtualActionInvoker2< RuntimeObject*, JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* >::Invoke(18 /* System.Void Newtonsoft.Json.Linq.JToken::set_Item(System.Object,Newtonsoft.Json.Linq.JToken) */, G_B6_2, G_B6_1, G_B6_0);
		// var filterAttributesObj = (filterAttributes != null) ? JObject.FromObject(filterAttributes) : new JObject();
		RuntimeObject* L_32 = ___filterAttributes3;
		if (L_32)
		{
			goto IL_00de;
		}
	}
	{
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_33 = (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1*)il2cpp_codegen_object_new(JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var);
		NullCheck(L_33);
		JObject__ctor_mF7F801B6729F7309319FF97690BCC68C7CA81CE4(L_33, NULL);
		G_B9_0 = L_33;
		goto IL_00e5;
	}

IL_00de:
	{
		RuntimeObject* L_34 = ___filterAttributes3;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_35;
		L_35 = JObject_FromObject_m5173BDC2D9FC1B112F5895863E74860550DE915B(L_34, NULL);
		G_B9_0 = L_35;
	}

IL_00e5:
	{
		V_1 = G_B9_0;
		// if (filterAttributesObj.ContainsKey("key"))
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_36 = V_1;
		NullCheck(L_36);
		bool L_37;
		L_37 = JObject_ContainsKey_m6B74EB007B052D50B2D7502999216B2CE62BBEF2(L_36, _stringLiteralE7D028CCE3B6E7B61AE2C752D7AE970DA04AB7C6, NULL);
		if (!L_37)
		{
			goto IL_0109;
		}
	}
	{
		// commonJobj["key"] = filterAttributesObj["key"];
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_38 = V_0;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_39 = V_1;
		NullCheck(L_39);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_40;
		L_40 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_39, _stringLiteralE7D028CCE3B6E7B61AE2C752D7AE970DA04AB7C6, NULL);
		NullCheck(L_38);
		JObject_set_Item_m38ACF4BABEDE80CF0138DA900AFFC5C4CC3E9221(L_38, _stringLiteralE7D028CCE3B6E7B61AE2C752D7AE970DA04AB7C6, L_40, NULL);
	}

IL_0109:
	{
		// if (filterAttributesObj.ContainsKey("type"))
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_41 = V_1;
		NullCheck(L_41);
		bool L_42;
		L_42 = JObject_ContainsKey_m6B74EB007B052D50B2D7502999216B2CE62BBEF2(L_41, _stringLiteralF3C6C902DBF80139640F6554F0C3392016A8ADF7, NULL);
		if (!L_42)
		{
			goto IL_012c;
		}
	}
	{
		// commonJobj["type"] = filterAttributesObj["type"];
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_43 = V_0;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_44 = V_1;
		NullCheck(L_44);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_45;
		L_45 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_44, _stringLiteralF3C6C902DBF80139640F6554F0C3392016A8ADF7, NULL);
		NullCheck(L_43);
		JObject_set_Item_m38ACF4BABEDE80CF0138DA900AFFC5C4CC3E9221(L_43, _stringLiteralF3C6C902DBF80139640F6554F0C3392016A8ADF7, L_45, NULL);
	}

IL_012c:
	{
		// if (filterAttributesObj.ContainsKey("schemaId"))
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_46 = V_1;
		NullCheck(L_46);
		bool L_47;
		L_47 = JObject_ContainsKey_m6B74EB007B052D50B2D7502999216B2CE62BBEF2(L_46, _stringLiteral29AA1803EE63BE5E6E59AD64966B8601C7579987, NULL);
		if (!L_47)
		{
			goto IL_014f;
		}
	}
	{
		// commonJobj["schemaId"] = filterAttributesObj["schemaId"];
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_48 = V_0;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_49 = V_1;
		NullCheck(L_49);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_50;
		L_50 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_49, _stringLiteral29AA1803EE63BE5E6E59AD64966B8601C7579987, NULL);
		NullCheck(L_48);
		JObject_set_Item_m38ACF4BABEDE80CF0138DA900AFFC5C4CC3E9221(L_48, _stringLiteral29AA1803EE63BE5E6E59AD64966B8601C7579987, L_50, NULL);
	}

IL_014f:
	{
		// return commonJobj.ToString();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_51 = V_0;
		NullCheck(L_51);
		String_t* L_52;
		L_52 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_51);
		return L_52;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::DoRequest(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_DoRequest_m82B45FDFBC6F8CB5F6EA90C6673FD99F2846AEBD (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, String_t* ___jsonText1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DownloadHandlerBuffer_t34C626F6513FA9A44FDDDEE85455CF2CD9DA5974_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m02ABAE8BB0E4A6356F33117FC781FB5E8F04C680_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m33E4BFC93CB232DD900322131149D15FF22FF12B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m74F27D7302F75A8327373EC0A364AFC11ADD0E76_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_GetEnumerator_mA5F623247EAF5110C665A71C65BE424E21AC8798_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass35_0_U3CDoRequestU3Eb__0_mF929AB208D7DBCBAEA4FFD588963D5090901A503_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UploadHandlerRaw_t0A24CF320CDF16F1BC6C5C086DE71A1908CBB91A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral14E338D17C42E552FA7AF42CDAE40CA1F0E8A04D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5A8A967B3F8A5D1396E5B6A1DD09C7E00F29A21B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5B58EBE31E594BF8FA4BEA3CD075473149322B18);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral64058CC688A96A90239811EF06C9D20DB0499C3E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9D5A3AE3D2B0B5E5AF5AB489000D9B88FA11E907);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC2DA60AE96E2C9EF3EAF20897A5AA957AFDF64EC);
		s_Il2CppMethodInitialized = true;
	}
	U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* V_0 = NULL;
	Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8 V_1;
	memset((&V_1), 0, sizeof(V_1));
	RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_0 = (U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548*)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CU3Ec__DisplayClass35_0__ctor_m88EE9567C366B10DDD2BB95173880695FCADE028(L_0, NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_1 = V_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_0 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_0), (void*)__this);
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_2 = V_0;
		String_t* L_3 = ___configType0;
		NullCheck(L_2);
		L_2->___configType_1 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&L_2->___configType_1), (void*)L_3);
		// var request = new RCUnityWebRequest();
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_4 = V_0;
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_5 = (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26*)il2cpp_codegen_object_new(RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26_il2cpp_TypeInfo_var);
		NullCheck(L_5);
		RCUnityWebRequest__ctor_m87B241477692D8A5E928205EB7E3EBB215675576(L_5, NULL);
		NullCheck(L_4);
		L_4->___request_2 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&L_4->___request_2), (void*)L_5);
		// request.unityWebRequest = new UnityWebRequest();
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_6 = V_0;
		NullCheck(L_6);
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_7 = L_6->___request_2;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_8 = (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F*)il2cpp_codegen_object_new(UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		UnityWebRequest__ctor_m68DB029AEF4E6093EDC2196C980134D2C0C969CA(L_8, NULL);
		NullCheck(L_7);
		RCUnityWebRequest_set_unityWebRequest_mEDEA0F5931A89608EB82EDE6408C25BA6F809C11(L_7, L_8, NULL);
		// request.method = UnityWebRequest.kHttpVerbPOST;
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_9 = V_0;
		NullCheck(L_9);
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_10 = L_9->___request_2;
		NullCheck(L_10);
		RCUnityWebRequest_set_method_mF644FCA7FE27EAD29819E54765546CFCFA143394(L_10, _stringLiteral14E338D17C42E552FA7AF42CDAE40CA1F0E8A04D, NULL);
		// request.SetRequestHeader("Content-Type", "application/json");
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_11 = V_0;
		NullCheck(L_11);
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_12 = L_11->___request_2;
		NullCheck(L_12);
		RCUnityWebRequest_SetRequestHeader_m4FB2E5E9AB59662AA749545FB0CCAD944AFF504F(L_12, _stringLiteral5B58EBE31E594BF8FA4BEA3CD075473149322B18, _stringLiteral64058CC688A96A90239811EF06C9D20DB0499C3E, NULL);
		// request.timeout = 10;
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_13 = V_0;
		NullCheck(L_13);
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_14 = L_13->___request_2;
		NullCheck(L_14);
		RCUnityWebRequest_set_timeout_m4A61D4CC6F764D6AAC1117BCB8A066FE191F0B2F(L_14, ((int32_t)10), NULL);
		// request.url = remoteConfigUrl;
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_15 = V_0;
		NullCheck(L_15);
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_16 = L_15->___request_2;
		NullCheck(L_16);
		RCUnityWebRequest_set_url_m75133D4C34C7305F8EED05A6B31A743A56D71899(L_16, _stringLiteral5A8A967B3F8A5D1396E5B6A1DD09C7E00F29A21B, NULL);
		// request.SetRequestHeader("Authorization", "Bearer " + _playerIdentityToken);
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_17 = V_0;
		NullCheck(L_17);
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_18 = L_17->___request_2;
		String_t* L_19 = __this->____playerIdentityToken_3;
		String_t* L_20;
		L_20 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(_stringLiteralC2DA60AE96E2C9EF3EAF20897A5AA957AFDF64EC, L_19, NULL);
		NullCheck(L_18);
		RCUnityWebRequest_SetRequestHeader_m4FB2E5E9AB59662AA749545FB0CCAD944AFF504F(L_18, _stringLiteral9D5A3AE3D2B0B5E5AF5AB489000D9B88FA11E907, L_20, NULL);
		// foreach(var headerProvider in requestHeaderProviders)
		List_1_t880482B1F033784B0BA7D9025F71CCB6C0F2379C* L_21 = __this->___requestHeaderProviders_6;
		NullCheck(L_21);
		Enumerator_tBEC166657735F4B571F6044768B43A598B5FCEF8 L_22;
		L_22 = List_1_GetEnumerator_mA5F623247EAF5110C665A71C65BE424E21AC8798(L_21, List_1_GetEnumerator_mA5F623247EAF5110C665A71C65BE424E21AC8798_RuntimeMethod_var);
		V_1 = L_22;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_00ce:
			{// begin finally (depth: 1)
				Enumerator_Dispose_m02ABAE8BB0E4A6356F33117FC781FB5E8F04C680((&V_1), Enumerator_Dispose_m02ABAE8BB0E4A6356F33117FC781FB5E8F04C680_RuntimeMethod_var);
				return;
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_00c3_1;
			}

IL_009f_1:
			{
				// foreach(var headerProvider in requestHeaderProviders)
				Func_1_t2A08DEC58BFB76B9DDF49BCF555A3342127229B5* L_23;
				L_23 = Enumerator_get_Current_m74F27D7302F75A8327373EC0A364AFC11ADD0E76_inline((&V_1), Enumerator_get_Current_m74F27D7302F75A8327373EC0A364AFC11ADD0E76_RuntimeMethod_var);
				// var header = headerProvider.Invoke();
				NullCheck(L_23);
				RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964 L_24;
				L_24 = Func_1_Invoke_mDD4D76DE063CBA57F374C98C27A50E8B72AE3BD5_inline(L_23, NULL);
				V_2 = L_24;
				// request.SetRequestHeader(header.key, header.value);
				U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_25 = V_0;
				NullCheck(L_25);
				RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_26 = L_25->___request_2;
				RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964 L_27 = V_2;
				String_t* L_28 = L_27.___key_0;
				RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964 L_29 = V_2;
				String_t* L_30 = L_29.___value_1;
				NullCheck(L_26);
				RCUnityWebRequest_SetRequestHeader_m4FB2E5E9AB59662AA749545FB0CCAD944AFF504F(L_26, L_28, L_30, NULL);
			}

IL_00c3_1:
			{
				// foreach(var headerProvider in requestHeaderProviders)
				bool L_31;
				L_31 = Enumerator_MoveNext_m33E4BFC93CB232DD900322131149D15FF22FF12B((&V_1), Enumerator_MoveNext_m33E4BFC93CB232DD900322131149D15FF22FF12B_RuntimeMethod_var);
				if (L_31)
				{
					goto IL_009f_1;
				}
			}
			{
				goto IL_00dc;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_00dc:
	{
		// request.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(jsonText));
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_32 = V_0;
		NullCheck(L_32);
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_33 = L_32->___request_2;
		Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* L_34;
		L_34 = Encoding_get_UTF8_m9700ADA8E0F244002B2A89B483F1B2133B8FE336(NULL);
		String_t* L_35 = ___jsonText1;
		NullCheck(L_34);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_36;
		L_36 = VirtualFuncInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, String_t* >::Invoke(18 /* System.Byte[] System.Text.Encoding::GetBytes(System.String) */, L_34, L_35);
		UploadHandlerRaw_t0A24CF320CDF16F1BC6C5C086DE71A1908CBB91A* L_37 = (UploadHandlerRaw_t0A24CF320CDF16F1BC6C5C086DE71A1908CBB91A*)il2cpp_codegen_object_new(UploadHandlerRaw_t0A24CF320CDF16F1BC6C5C086DE71A1908CBB91A_il2cpp_TypeInfo_var);
		NullCheck(L_37);
		UploadHandlerRaw__ctor_m168C957B67E29CB3072E3542044D37E2F16C42B7(L_37, L_36, NULL);
		NullCheck(L_33);
		RCUnityWebRequest_set_uploadHandler_mCAC1021CD5A38F85FD3CC03EC5227562D385DE6D(L_33, L_37, NULL);
		// request.downloadHandler = new DownloadHandlerBuffer();
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_38 = V_0;
		NullCheck(L_38);
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_39 = L_38->___request_2;
		DownloadHandlerBuffer_t34C626F6513FA9A44FDDDEE85455CF2CD9DA5974* L_40 = (DownloadHandlerBuffer_t34C626F6513FA9A44FDDDEE85455CF2CD9DA5974*)il2cpp_codegen_object_new(DownloadHandlerBuffer_t34C626F6513FA9A44FDDDEE85455CF2CD9DA5974_il2cpp_TypeInfo_var);
		NullCheck(L_40);
		DownloadHandlerBuffer__ctor_m5EE7C9E8AB468B2B937A7C9C66B4176A884147AF(L_40, NULL);
		NullCheck(L_39);
		RCUnityWebRequest_set_downloadHandler_m17CAEC803C5C70D872206FD3BE6271AC39102924(L_39, L_40, NULL);
		// request.SendWebRequest().completed += op => {
		//     var origin = ConfigOrigin.Remote;
		//     var webRequest = ((UnityWebRequestAsyncOperation)op).webRequest;
		//     if (webRequest.isHttpError || webRequest.isNetworkError)
		//     {
		//         var configResponse = ParseResponse(origin, null, null);
		//         HandleConfigResponse(configType, configResponse);
		//     }
		//     else
		//     {
		//         var configResponse = ParseResponse(origin, request.GetResponseHeaders(), request.downloadHandler.text);
		//         HandleConfigResponse(configType, configResponse);
		//     }
		//     webRequest.Dispose();
		// };
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_41 = V_0;
		NullCheck(L_41);
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_42 = L_41->___request_2;
		NullCheck(L_42);
		UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C* L_43;
		L_43 = RCUnityWebRequest_SendWebRequest_m45E3D6DB2C4C4EF78C6D48674D583CEC27D77683(L_42, NULL);
		U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* L_44 = V_0;
		Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB* L_45 = (Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB*)il2cpp_codegen_object_new(Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB_il2cpp_TypeInfo_var);
		NullCheck(L_45);
		Action_1__ctor_m33ABB7530487276910BEFB499A97D33FB2E06D7D(L_45, L_44, (intptr_t)((void*)U3CU3Ec__DisplayClass35_0_U3CDoRequestU3Eb__0_mF929AB208D7DBCBAEA4FFD588963D5090901A503_RuntimeMethod_var), NULL);
		NullCheck(L_43);
		AsyncOperation_add_completed_mD6F21BA8127D6D4B7ABDEFAA995A7A347A20A793(L_43, L_45, NULL);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::HandleConfigResponse(System.String,Unity.RemoteConfig.ConfigResponse)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_HandleConfigResponse_m8A7939905898FE82F01194EF38C55DABCFD362D0 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___configType0, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___configResponse1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* G_B4_0 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* G_B3_0 = NULL;
	{
		// if (!configs.ContainsKey(configType)) configs[configType] = new RuntimeConfig(configType);
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_0 = __this->___configs_2;
		String_t* L_1 = ___configType0;
		NullCheck(L_0);
		bool L_2;
		L_2 = Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1(L_0, L_1, Dictionary_2_ContainsKey_mE3BDF38A4B51037A64D107ED4D3B398FEA5477D1_RuntimeMethod_var);
		if (L_2)
		{
			goto IL_0020;
		}
	}
	{
		// if (!configs.ContainsKey(configType)) configs[configType] = new RuntimeConfig(configType);
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_3 = __this->___configs_2;
		String_t* L_4 = ___configType0;
		String_t* L_5 = ___configType0;
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_6 = (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99*)il2cpp_codegen_object_new(RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var);
		NullCheck(L_6);
		RuntimeConfig__ctor_m86B59B69E6F3D781991235921A872D8362417EF7(L_6, L_5, NULL);
		NullCheck(L_3);
		Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842(L_3, L_4, L_6, Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var);
	}

IL_0020:
	{
		// configs[configType].HandleConfigResponse(configResponse);
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_7 = __this->___configs_2;
		String_t* L_8 = ___configType0;
		NullCheck(L_7);
		RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_9;
		L_9 = Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5(L_7, L_8, Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_10 = ___configResponse1;
		NullCheck(L_9);
		RuntimeConfig_HandleConfigResponse_mF33BFEEFEA29FE9B434CFF49D921AA7305D1A021(L_9, L_10, NULL);
		// FetchCompleted?.Invoke(configResponse);
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_11 = __this->___FetchCompleted_13;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_12 = L_11;
		G_B3_0 = L_12;
		if (L_12)
		{
			G_B4_0 = L_12;
			goto IL_003d;
		}
	}
	{
		return;
	}

IL_003d:
	{
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_13 = ___configResponse1;
		NullCheck(G_B4_0);
		Action_1_Invoke_m496875C3D21245101D0AC44B050159FC1FBFB390_inline(G_B4_0, L_13, NULL);
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::SaveCache(Unity.RemoteConfig.ConfigResponse)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_SaveCache_m43661F9802E18D7B3BDE3E372AF46D72E08FB5E4 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___response0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mCF1D722A2A472811B0A1D81205BD73AD064AFDC1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Keys_m0A27AAFC34C1E6AC8FFA238F61151F2C22748599_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_m946DA5F7EED6E700A1D4B25A93897A1248ED5A70_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t1350928D43387352EDB22C6979983B8129804127_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m62199928E4E61AF736738A346A85DC979AF27D2C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m203F36D1E99FED6FCC96C594AE5D5B70981FD140_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m7AA79A472AE62BDA8AE5DACD99FF84BEF4DE800E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JsonConvert_t01281FFED14CC2AEFABB6608315D90ED5C46E0C2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyCollection_GetEnumerator_m9CE20FA88F49E3AC89C3194787B1698BB7A0F700_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_t1350928D43387352EDB22C6979983B8129804127* V_0 = NULL;
	Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B V_1;
	memset((&V_1), 0, sizeof(V_1));
	String_t* V_2 = NULL;
	StreamWriter_t6E7DF7D524AA3C018A65F62EE80779873ED4D1E4* V_3 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		// if(response.requestOrigin == ConfigOrigin.Remote)
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_0 = ___response0;
		int32_t L_1 = L_0.___requestOrigin_0;
		if ((!(((uint32_t)L_1) == ((uint32_t)2))))
		{
			goto IL_0096;
		}
	}
	{
		// var responsesToCache = new Dictionary<string, ConfigResponse>();
		Dictionary_2_t1350928D43387352EDB22C6979983B8129804127* L_2 = (Dictionary_2_t1350928D43387352EDB22C6979983B8129804127*)il2cpp_codegen_object_new(Dictionary_2_t1350928D43387352EDB22C6979983B8129804127_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		Dictionary_2__ctor_mCF1D722A2A472811B0A1D81205BD73AD064AFDC1(L_2, Dictionary_2__ctor_mCF1D722A2A472811B0A1D81205BD73AD064AFDC1_RuntimeMethod_var);
		V_0 = L_2;
		// foreach (var configType in configs.Keys)
		Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_3 = __this->___configs_2;
		NullCheck(L_3);
		KeyCollection_tDABE6E934B2EF300EC234A664076A202E3BFA4BE* L_4;
		L_4 = Dictionary_2_get_Keys_m0A27AAFC34C1E6AC8FFA238F61151F2C22748599(L_3, Dictionary_2_get_Keys_m0A27AAFC34C1E6AC8FFA238F61151F2C22748599_RuntimeMethod_var);
		NullCheck(L_4);
		Enumerator_t9E4D0592A9DA6EE72C3523C37FEC85783A9D403B L_5;
		L_5 = KeyCollection_GetEnumerator_m9CE20FA88F49E3AC89C3194787B1698BB7A0F700(L_4, KeyCollection_GetEnumerator_m9CE20FA88F49E3AC89C3194787B1698BB7A0F700_RuntimeMethod_var);
		V_1 = L_5;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0050:
			{// begin finally (depth: 1)
				Enumerator_Dispose_m62199928E4E61AF736738A346A85DC979AF27D2C((&V_1), Enumerator_Dispose_m62199928E4E61AF736738A346A85DC979AF27D2C_RuntimeMethod_var);
				return;
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_0045_1;
			}

IL_0025_1:
			{
				// foreach (var configType in configs.Keys)
				String_t* L_6;
				L_6 = Enumerator_get_Current_m7AA79A472AE62BDA8AE5DACD99FF84BEF4DE800E_inline((&V_1), Enumerator_get_Current_m7AA79A472AE62BDA8AE5DACD99FF84BEF4DE800E_RuntimeMethod_var);
				V_2 = L_6;
				// responsesToCache[configType] = configs[configType].ConfigResponse;
				Dictionary_2_t1350928D43387352EDB22C6979983B8129804127* L_7 = V_0;
				String_t* L_8 = V_2;
				Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_9 = __this->___configs_2;
				String_t* L_10 = V_2;
				NullCheck(L_9);
				RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_11;
				L_11 = Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5(L_9, L_10, Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
				NullCheck(L_11);
				ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_12 = L_11->___ConfigResponse_4;
				NullCheck(L_7);
				Dictionary_2_set_Item_m946DA5F7EED6E700A1D4B25A93897A1248ED5A70(L_7, L_8, L_12, Dictionary_2_set_Item_m946DA5F7EED6E700A1D4B25A93897A1248ED5A70_RuntimeMethod_var);
			}

IL_0045_1:
			{
				// foreach (var configType in configs.Keys)
				bool L_13;
				L_13 = Enumerator_MoveNext_m203F36D1E99FED6FCC96C594AE5D5B70981FD140((&V_1), Enumerator_MoveNext_m203F36D1E99FED6FCC96C594AE5D5B70981FD140_RuntimeMethod_var);
				if (L_13)
				{
					goto IL_0025_1;
				}
			}
			{
				goto IL_005e;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_005e:
	{
	}
	try
	{// begin try (depth: 1)
		{
			// using (var writer = File.CreateText(Path.Combine(Application.persistentDataPath, cacheFile)))
			String_t* L_14;
			L_14 = Application_get_persistentDataPath_m787EBC9B0862E7617DCD6CABD2147E61717EAC17(NULL);
			String_t* L_15 = __this->___cacheFile_8;
			il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
			String_t* L_16;
			L_16 = Path_Combine_m64754D4E08990CE1EBC41CDF197807EE4B115474(L_14, L_15, NULL);
			StreamWriter_t6E7DF7D524AA3C018A65F62EE80779873ED4D1E4* L_17;
			L_17 = File_CreateText_mC919C8F57836A16849C3143D6EC71A6DF9BBC95C(L_16, NULL);
			V_3 = L_17;
		}
		{
			auto __finallyBlock = il2cpp::utils::Finally([&]
			{

FINALLY_0083_1:
				{// begin finally (depth: 2)
					{
						StreamWriter_t6E7DF7D524AA3C018A65F62EE80779873ED4D1E4* L_18 = V_3;
						if (!L_18)
						{
							goto IL_008c_1;
						}
					}
					{
						StreamWriter_t6E7DF7D524AA3C018A65F62EE80779873ED4D1E4* L_19 = V_3;
						NullCheck(L_19);
						InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_19);
					}

IL_008c_1:
					{
						return;
					}
				}// end finally (depth: 2)
			});
			try
			{// begin try (depth: 2)
				// writer.Write(JsonConvert.SerializeObject(responsesToCache));
				StreamWriter_t6E7DF7D524AA3C018A65F62EE80779873ED4D1E4* L_20 = V_3;
				Dictionary_2_t1350928D43387352EDB22C6979983B8129804127* L_21 = V_0;
				il2cpp_codegen_runtime_class_init_inline(JsonConvert_t01281FFED14CC2AEFABB6608315D90ED5C46E0C2_il2cpp_TypeInfo_var);
				String_t* L_22;
				L_22 = JsonConvert_SerializeObject_mEF78C5DAFDB944E8E19657EB92F5394370B27CAF(L_21, NULL);
				NullCheck(L_20);
				VirtualActionInvoker1< String_t* >::Invoke(16 /* System.Void System.IO.TextWriter::Write(System.String) */, L_20, L_22);
				// }
				goto IL_008d_1;
			}// end try (depth: 2)
			catch(Il2CppExceptionWrapper& e)
			{
				__finallyBlock.StoreException(e.ex);
			}
		}

IL_008d_1:
		{
			// }
			goto IL_0096;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_008f;
		}
		throw e;
	}

CATCH_008f:
	{// begin catch(System.Exception)
		// Debug.LogError(e);
		il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var)));
		Debug_LogError_m059825802BB6AF7EA9693FEBEEB0D85F59A3E38E(((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*)), NULL);
		// }
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0096;
	}// end catch (depth: 1)

IL_0096:
	{
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl::LoadFromCache()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigManagerImpl_LoadFromCache_m308A9C3C2867E19A7348741D3BF09EBCAAE4D156 (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigManagerImpl_LoadFromCache_m308A9C3C2867E19A7348741D3BF09EBCAAE4D156_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_1_tB643E521895AE2CA45F187028EC1470EC9DCEEDA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JToken_ToObject_TisConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_mDE14C69A8F47BC3C3D33A3EED6D30FB2314F9EDA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Key_m58D71AFA188B3B9B9C6FFE10C720DE49333F1A08_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Value_m2BC92622340FE4FDF5ECB521489A8AC781D8BA19_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	KeyValuePair_2_t25BF56B44F40AC19698F68DD29593E307D428F8B V_3;
	memset((&V_3), 0, sizeof(V_3));
	String_t* V_4 = NULL;
	ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 V_5;
	memset((&V_5), 0, sizeof(V_5));
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		{
			// using (var reader = File.Open(Path.Combine(Application.persistentDataPath, cacheFile), FileMode.Open))
			String_t* L_0;
			L_0 = Application_get_persistentDataPath_m787EBC9B0862E7617DCD6CABD2147E61717EAC17(NULL);
			String_t* L_1 = __this->___cacheFile_8;
			il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
			String_t* L_2;
			L_2 = Path_Combine_m64754D4E08990CE1EBC41CDF197807EE4B115474(L_0, L_1, NULL);
			FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_3;
			L_3 = File_Open_m9C6D5876B037A5A8341D216B767D4C8BE7084326(L_2, 3, NULL);
			V_1 = L_3;
		}
		{
			auto __finallyBlock = il2cpp::utils::Finally([&]
			{

FINALLY_0036_1:
				{// begin finally (depth: 2)
					{
						FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_4 = V_1;
						if (!L_4)
						{
							goto IL_003f_1;
						}
					}
					{
						FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_5 = V_1;
						NullCheck(L_5);
						InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_5);
					}

IL_003f_1:
					{
						return;
					}
				}// end finally (depth: 2)
			});
			try
			{// begin try (depth: 2)
				// bodyResult = new byte[reader.Length];
				FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_6 = V_1;
				NullCheck(L_6);
				int64_t L_7;
				L_7 = VirtualFuncInvoker0< int64_t >::Invoke(11 /* System.Int64 System.IO.Stream::get_Length() */, L_6);
				if ((int64_t)(L_7) > INTPTR_MAX) IL2CPP_RAISE_MANAGED_EXCEPTION(il2cpp_codegen_get_overflow_exception(), ConfigManagerImpl_LoadFromCache_m308A9C3C2867E19A7348741D3BF09EBCAAE4D156_RuntimeMethod_var);
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((intptr_t)L_7));
				V_0 = L_8;
				// reader.Read(bodyResult, 0, (int)reader.Length);
				FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_9 = V_1;
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_10 = V_0;
				FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_11 = V_1;
				NullCheck(L_11);
				int64_t L_12;
				L_12 = VirtualFuncInvoker0< int64_t >::Invoke(11 /* System.Int64 System.IO.Stream::get_Length() */, L_11);
				NullCheck(L_9);
				int32_t L_13;
				L_13 = VirtualFuncInvoker3< int32_t, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t, int32_t >::Invoke(31 /* System.Int32 System.IO.Stream::Read(System.Byte[],System.Int32,System.Int32) */, L_9, L_10, 0, ((int32_t)L_12));
				// }
				goto IL_0040_1;
			}// end try (depth: 2)
			catch(Il2CppExceptionWrapper& e)
			{
				__finallyBlock.StoreException(e.ex);
			}
		}

IL_0040_1:
		{
			// var bodyString = Encoding.ASCII.GetString(bodyResult);
			Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* L_14;
			L_14 = Encoding_get_ASCII_mCC17A741582B0AB778D261452FD515EBD7297562(NULL);
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_15 = V_0;
			NullCheck(L_14);
			String_t* L_16;
			L_16 = VirtualFuncInvoker1< String_t*, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* >::Invoke(35 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_14, L_15);
			// var bodyJObject = JObject.Parse(bodyString);
			JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_17;
			L_17 = JObject_Parse_mAFE39B83D08F5D889D34F83E017661FF28E4D0AC(L_16, NULL);
			// foreach (var kv in bodyJObject)
			NullCheck(L_17);
			RuntimeObject* L_18;
			L_18 = JObject_GetEnumerator_mDB9AA9D5339E5EFD3D9D968B778E651D2CA693BB(L_17, NULL);
			V_2 = L_18;
		}
		{
			auto __finallyBlock = il2cpp::utils::Finally([&]
			{

FINALLY_00b7_1:
				{// begin finally (depth: 2)
					{
						RuntimeObject* L_19 = V_2;
						if (!L_19)
						{
							goto IL_00c0_1;
						}
					}
					{
						RuntimeObject* L_20 = V_2;
						NullCheck(L_20);
						InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_20);
					}

IL_00c0_1:
					{
						return;
					}
				}// end finally (depth: 2)
			});
			try
			{// begin try (depth: 2)
				{
					goto IL_00ad_2;
				}

IL_0058_2:
				{
					// foreach (var kv in bodyJObject)
					RuntimeObject* L_21 = V_2;
					NullCheck(L_21);
					KeyValuePair_2_t25BF56B44F40AC19698F68DD29593E307D428F8B L_22;
					L_22 = InterfaceFuncInvoker0< KeyValuePair_2_t25BF56B44F40AC19698F68DD29593E307D428F8B >::Invoke(0 /* T System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,Newtonsoft.Json.Linq.JToken>>::get_Current() */, IEnumerator_1_tB643E521895AE2CA45F187028EC1470EC9DCEEDA_il2cpp_TypeInfo_var, L_21);
					V_3 = L_22;
					// var configType = kv.Key;
					String_t* L_23;
					L_23 = KeyValuePair_2_get_Key_m58D71AFA188B3B9B9C6FFE10C720DE49333F1A08_inline((&V_3), KeyValuePair_2_get_Key_m58D71AFA188B3B9B9C6FFE10C720DE49333F1A08_RuntimeMethod_var);
					V_4 = L_23;
					// if (kv.Value.Type == JTokenType.Object)
					JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_24;
					L_24 = KeyValuePair_2_get_Value_m2BC92622340FE4FDF5ECB521489A8AC781D8BA19_inline((&V_3), KeyValuePair_2_get_Value_m2BC92622340FE4FDF5ECB521489A8AC781D8BA19_RuntimeMethod_var);
					NullCheck(L_24);
					int32_t L_25;
					L_25 = VirtualFuncInvoker0< int32_t >::Invoke(15 /* Newtonsoft.Json.Linq.JTokenType Newtonsoft.Json.Linq.JToken::get_Type() */, L_24);
					if ((!(((uint32_t)L_25) == ((uint32_t)1))))
					{
						goto IL_00ad_2;
					}
				}
				{
					// var cachedConfigResponse = kv.Value.ToObject<ConfigResponse>();
					JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_26;
					L_26 = KeyValuePair_2_get_Value_m2BC92622340FE4FDF5ECB521489A8AC781D8BA19_inline((&V_3), KeyValuePair_2_get_Value_m2BC92622340FE4FDF5ECB521489A8AC781D8BA19_RuntimeMethod_var);
					NullCheck(L_26);
					ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_27;
					L_27 = JToken_ToObject_TisConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_mDE14C69A8F47BC3C3D33A3EED6D30FB2314F9EDA(L_26, JToken_ToObject_TisConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_mDE14C69A8F47BC3C3D33A3EED6D30FB2314F9EDA_RuntimeMethod_var);
					V_5 = L_27;
					// configs[configType] = new RuntimeConfig(configType);
					Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_28 = __this->___configs_2;
					String_t* L_29 = V_4;
					String_t* L_30 = V_4;
					RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_31 = (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99*)il2cpp_codegen_object_new(RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99_il2cpp_TypeInfo_var);
					NullCheck(L_31);
					RuntimeConfig__ctor_m86B59B69E6F3D781991235921A872D8362417EF7(L_31, L_30, NULL);
					NullCheck(L_28);
					Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842(L_28, L_29, L_31, Dictionary_2_set_Item_mA414A2514F701491AEE38975BAA968CA93A43842_RuntimeMethod_var);
					// configs[configType].HandleConfigResponse(cachedConfigResponse);
					Dictionary_2_t92B6BFD2A090475A168F248C72CD5C1A7DE8FD1D* L_32 = __this->___configs_2;
					String_t* L_33 = V_4;
					NullCheck(L_32);
					RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* L_34;
					L_34 = Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5(L_32, L_33, Dictionary_2_get_Item_mAEF5698438F9400FA8C94A3D317B8B9968A5B7B5_RuntimeMethod_var);
					ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_35 = V_5;
					NullCheck(L_34);
					RuntimeConfig_HandleConfigResponse_mF33BFEEFEA29FE9B434CFF49D921AA7305D1A021(L_34, L_35, NULL);
				}

IL_00ad_2:
				{
					// foreach (var kv in bodyJObject)
					RuntimeObject* L_36 = V_2;
					NullCheck(L_36);
					bool L_37;
					L_37 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var, L_36);
					if (L_37)
					{
						goto IL_0058_2;
					}
				}
				{
					goto IL_00c1_1;
				}
			}// end try (depth: 2)
			catch(Il2CppExceptionWrapper& e)
			{
				__finallyBlock.StoreException(e.ex);
			}
		}

IL_00c1_1:
		{
			// }
			goto IL_00d0;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_00c3;
		}
		throw e;
	}

CATCH_00c3:
	{// begin catch(System.Object)
		// catch
		// Debug.Log("Failed to load config from cache.");
		il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var)));
		Debug_Log_m86567BCF22BBE7809747817453CACA0E41E68219(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral60EF1C26D54FB5A5DFE16A86970F69F7F4AB4D34)), NULL);
		// }
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_00d0;
	}// end catch (depth: 1)

IL_00d0:
	{
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Unity.RemoteConfig.ConfigManagerImpl/<>c__DisplayClass35_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass35_0__ctor_m88EE9567C366B10DDD2BB95173880695FCADE028 (U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Void Unity.RemoteConfig.ConfigManagerImpl/<>c__DisplayClass35_0::<DoRequest>b__0(UnityEngine.AsyncOperation)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass35_0_U3CDoRequestU3Eb__0_mF929AB208D7DBCBAEA4FFD588963D5090901A503 (U3CU3Ec__DisplayClass35_0_t66DAA602FF74E3DA3E6829A499443FF9D1890548* __this, AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C* ___op0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* V_1 = NULL;
	ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 V_2;
	memset((&V_2), 0, sizeof(V_2));
	ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 V_3;
	memset((&V_3), 0, sizeof(V_3));
	{
		// var origin = ConfigOrigin.Remote;
		V_0 = 2;
		// var webRequest = ((UnityWebRequestAsyncOperation)op).webRequest;
		AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C* L_0 = ___op0;
		NullCheck(((UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C*)CastclassClass((RuntimeObject*)L_0, UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C_il2cpp_TypeInfo_var)));
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_1;
		L_1 = UnityWebRequestAsyncOperation_get_webRequest_mF67D15420C7C1C4DCA1BD6F839048A0542998BC3_inline(((UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C*)CastclassClass((RuntimeObject*)L_0, UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C_il2cpp_TypeInfo_var)), NULL);
		V_1 = L_1;
		// if (webRequest.isHttpError || webRequest.isNetworkError)
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_2 = V_1;
		NullCheck(L_2);
		bool L_3;
		L_3 = UnityWebRequest_get_isHttpError_m945BA480A179E05CC9659846414D9521ED648ED5(L_2, NULL);
		if (L_3)
		{
			goto IL_001e;
		}
	}
	{
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_4 = V_1;
		NullCheck(L_4);
		bool L_5;
		L_5 = UnityWebRequest_get_isNetworkError_m036684411466688E71E67CDD3703BAC9035A56F0(L_4, NULL);
		if (!L_5)
		{
			goto IL_0041;
		}
	}

IL_001e:
	{
		// var configResponse = ParseResponse(origin, null, null);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_6 = __this->___U3CU3E4__this_0;
		int32_t L_7 = V_0;
		NullCheck(L_6);
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_8;
		L_8 = ConfigManagerImpl_ParseResponse_m66ADE9C6AE574604ADA656D2233F8DE1F51DE897(L_6, L_7, (Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83*)NULL, (String_t*)NULL, NULL);
		V_2 = L_8;
		// HandleConfigResponse(configType, configResponse);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_9 = __this->___U3CU3E4__this_0;
		String_t* L_10 = __this->___configType_1;
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_11 = V_2;
		NullCheck(L_9);
		ConfigManagerImpl_HandleConfigResponse_m8A7939905898FE82F01194EF38C55DABCFD362D0(L_9, L_10, L_11, NULL);
		goto IL_007b;
	}

IL_0041:
	{
		// var configResponse = ParseResponse(origin, request.GetResponseHeaders(), request.downloadHandler.text);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_12 = __this->___U3CU3E4__this_0;
		int32_t L_13 = V_0;
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_14 = __this->___request_2;
		NullCheck(L_14);
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_15;
		L_15 = RCUnityWebRequest_GetResponseHeaders_mD82C15C8DCE779536154FABB25B151FB80F2992D(L_14, NULL);
		RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* L_16 = __this->___request_2;
		NullCheck(L_16);
		DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* L_17;
		L_17 = RCUnityWebRequest_get_downloadHandler_mFD12B9B005ECD0E5DB8DED43970F986427B6D148(L_16, NULL);
		NullCheck(L_17);
		String_t* L_18;
		L_18 = DownloadHandler_get_text_mA6DE5CB2647A21E577B963708DC3D0DA4DBFE7D8(L_17, NULL);
		NullCheck(L_12);
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_19;
		L_19 = ConfigManagerImpl_ParseResponse_m66ADE9C6AE574604ADA656D2233F8DE1F51DE897(L_12, L_13, L_15, L_18, NULL);
		V_3 = L_19;
		// HandleConfigResponse(configType, configResponse);
		ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* L_20 = __this->___U3CU3E4__this_0;
		String_t* L_21 = __this->___configType_1;
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_22 = V_3;
		NullCheck(L_20);
		ConfigManagerImpl_HandleConfigResponse_m8A7939905898FE82F01194EF38C55DABCFD362D0(L_20, L_21, L_22, NULL);
	}

IL_007b:
	{
		// webRequest.Dispose();
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_23 = V_1;
		NullCheck(L_23);
		UnityWebRequest_Dispose_m9F43494C0FEA530A97D3F2AF3D425CCC7670753A(L_23, NULL);
		// };
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: Unity.RemoteConfig.ConfigResponse
IL2CPP_EXTERN_C void ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshal_pinvoke(const ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871& unmarshaled, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshaled_pinvoke& marshaled)
{
	Exception_t* ___body_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'body' of type 'ConfigResponse': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___body_2Exception, NULL);
}
IL2CPP_EXTERN_C void ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshal_pinvoke_back(const ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshaled_pinvoke& marshaled, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871& unmarshaled)
{
	Exception_t* ___body_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'body' of type 'ConfigResponse': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___body_2Exception, NULL);
}
// Conversion method for clean up from marshalling of: Unity.RemoteConfig.ConfigResponse
IL2CPP_EXTERN_C void ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshal_pinvoke_cleanup(ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: Unity.RemoteConfig.ConfigResponse
IL2CPP_EXTERN_C void ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshal_com(const ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871& unmarshaled, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshaled_com& marshaled)
{
	Exception_t* ___body_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'body' of type 'ConfigResponse': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___body_2Exception, NULL);
}
IL2CPP_EXTERN_C void ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshal_com_back(const ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshaled_com& marshaled, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871& unmarshaled)
{
	Exception_t* ___body_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'body' of type 'ConfigResponse': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___body_2Exception, NULL);
}
// Conversion method for clean up from marshalling of: Unity.RemoteConfig.ConfigResponse
IL2CPP_EXTERN_C void ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshal_com_cleanup(ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871_marshaled_com& marshaled)
{
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: Unity.RemoteConfig.RemoteConfigRequest
IL2CPP_EXTERN_C void RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshal_pinvoke(const RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815& unmarshaled, RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshaled_pinvoke& marshaled)
{
	Exception_t* ___key_4Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'key' of type 'RemoteConfigRequest'.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___key_4Exception, NULL);
}
IL2CPP_EXTERN_C void RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshal_pinvoke_back(const RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshaled_pinvoke& marshaled, RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815& unmarshaled)
{
	Exception_t* ___key_4Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'key' of type 'RemoteConfigRequest'.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___key_4Exception, NULL);
}
// Conversion method for clean up from marshalling of: Unity.RemoteConfig.RemoteConfigRequest
IL2CPP_EXTERN_C void RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshal_pinvoke_cleanup(RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: Unity.RemoteConfig.RemoteConfigRequest
IL2CPP_EXTERN_C void RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshal_com(const RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815& unmarshaled, RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshaled_com& marshaled)
{
	Exception_t* ___key_4Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'key' of type 'RemoteConfigRequest'.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___key_4Exception, NULL);
}
IL2CPP_EXTERN_C void RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshal_com_back(const RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshaled_com& marshaled, RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815& unmarshaled)
{
	Exception_t* ___key_4Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'key' of type 'RemoteConfigRequest'.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___key_4Exception, NULL);
}
// Conversion method for clean up from marshalling of: Unity.RemoteConfig.RemoteConfigRequest
IL2CPP_EXTERN_C void RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshal_com_cleanup(RemoteConfigRequest_t0EC95E79C1E931426E1E64570A10438E4E170815_marshaled_com& marshaled)
{
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: Unity.RemoteConfig.RequestHeaderTuple
IL2CPP_EXTERN_C void RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshal_pinvoke(const RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964& unmarshaled, RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshaled_pinvoke& marshaled)
{
	marshaled.___key_0 = il2cpp_codegen_marshal_string(unmarshaled.___key_0);
	marshaled.___value_1 = il2cpp_codegen_marshal_string(unmarshaled.___value_1);
}
IL2CPP_EXTERN_C void RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshal_pinvoke_back(const RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshaled_pinvoke& marshaled, RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964& unmarshaled)
{
	unmarshaled.___key_0 = il2cpp_codegen_marshal_string_result(marshaled.___key_0);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___key_0), (void*)il2cpp_codegen_marshal_string_result(marshaled.___key_0));
	unmarshaled.___value_1 = il2cpp_codegen_marshal_string_result(marshaled.___value_1);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___value_1), (void*)il2cpp_codegen_marshal_string_result(marshaled.___value_1));
}
// Conversion method for clean up from marshalling of: Unity.RemoteConfig.RequestHeaderTuple
IL2CPP_EXTERN_C void RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshal_pinvoke_cleanup(RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___key_0);
	marshaled.___key_0 = NULL;
	il2cpp_codegen_marshal_free(marshaled.___value_1);
	marshaled.___value_1 = NULL;
}
// Conversion methods for marshalling of: Unity.RemoteConfig.RequestHeaderTuple
IL2CPP_EXTERN_C void RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshal_com(const RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964& unmarshaled, RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshaled_com& marshaled)
{
	marshaled.___key_0 = il2cpp_codegen_marshal_bstring(unmarshaled.___key_0);
	marshaled.___value_1 = il2cpp_codegen_marshal_bstring(unmarshaled.___value_1);
}
IL2CPP_EXTERN_C void RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshal_com_back(const RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshaled_com& marshaled, RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964& unmarshaled)
{
	unmarshaled.___key_0 = il2cpp_codegen_marshal_bstring_result(marshaled.___key_0);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___key_0), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___key_0));
	unmarshaled.___value_1 = il2cpp_codegen_marshal_bstring_result(marshaled.___value_1);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___value_1), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___value_1));
}
// Conversion method for clean up from marshalling of: Unity.RemoteConfig.RequestHeaderTuple
IL2CPP_EXTERN_C void RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshal_com_cleanup(RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___key_0);
	marshaled.___key_0 = NULL;
	il2cpp_codegen_marshal_free_bstring(marshaled.___value_1);
	marshaled.___value_1 = NULL;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Unity.RemoteConfig.UnityAttributes::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAttributes__ctor_mD96F9FE53FA0BF66C1E0BA6775522D429011742E (UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ApplicationInstallMode_tC04028D1A53D6C33BFE4678D81B891F6214C7CDA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Resolution_tDF215F567EEFFD07B9A8FB7CEACC08EA6B8B9525 V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	{
		// public UnityAttributes()
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// osVersion = SystemInfo.operatingSystem;
		String_t* L_0;
		L_0 = SystemInfo_get_operatingSystem_m441DFAEFA81C9B5AF19D5C486469EDBD674490A8(NULL);
		__this->___osVersion_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___osVersion_0), (void*)L_0);
		// appVersion = Application.version;
		String_t* L_1;
		L_1 = Application_get_version_mD6AC9813ABCAD4D2A1F764F99E26068CA5B830F2(NULL);
		__this->___appVersion_1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___appVersion_1), (void*)L_1);
		// rootedJailbroken = Application.sandboxType == ApplicationSandboxType.SandboxBroken;
		int32_t L_2;
		L_2 = Application_get_sandboxType_m612A691D946B19DFAF0211D77047EFFA0C9D3E85(NULL);
		__this->___rootedJailbroken_2 = (bool)((((int32_t)L_2) == ((int32_t)3))? 1 : 0);
		// model = GetDeviceModel();
		String_t* L_3;
		L_3 = UnityAttributes_GetDeviceModel_mE18196FBE4733B5F7F8DAFE82FAEB2ED8DE5C071(__this, NULL);
		__this->___model_3 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___model_3), (void*)L_3);
		// cpu = SystemInfo.processorType;
		String_t* L_4;
		L_4 = SystemInfo_get_processorType_mFF77AA1DFEF20F32947689FC751856CD7FB0D211(NULL);
		__this->___cpu_4 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___cpu_4), (void*)L_4);
		// cpuCount = SystemInfo.processorCount;
		int32_t L_5;
		L_5 = SystemInfo_get_processorCount_m9161DEC1BC6A1D2431C23A291D3EDB288C2D9BD0(NULL);
		__this->___cpuCount_5 = L_5;
		// cpuFrequency = SystemInfo.processorFrequency;
		int32_t L_6;
		L_6 = SystemInfo_get_processorFrequency_mEE3979653401947B835DA2F61DDEE1665610DC55(NULL);
		__this->___cpuFrequency_6 = L_6;
		// ram = SystemInfo.systemMemorySize;
		int32_t L_7;
		L_7 = SystemInfo_get_systemMemorySize_mB292B50D7F2F0AF1A450A87F3A883E4ABEC00D89(NULL);
		__this->___ram_7 = L_7;
		// vram = SystemInfo.graphicsMemorySize;
		int32_t L_8;
		L_8 = SystemInfo_get_graphicsMemorySize_m53DF8C3C07E8A470CB0308C234B032F5CAA893DE(NULL);
		__this->___vram_8 = L_8;
		// screen = Screen.currentResolution.ToString();
		Resolution_tDF215F567EEFFD07B9A8FB7CEACC08EA6B8B9525 L_9;
		L_9 = Screen_get_currentResolution_mDA9FEB72E2C16BD66D709E94CD9504BF7CAC899E(NULL);
		V_0 = L_9;
		String_t* L_10;
		L_10 = Resolution_ToString_m058CE120CC83F314D0C8D4A706F9AA068BC9CF34((&V_0), NULL);
		__this->___screen_9 = L_10;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___screen_9), (void*)L_10);
		// dpi = (int)Screen.dpi;
		float L_11;
		L_11 = Screen_get_dpi_mD5BB95E605FABD335F0D4736EE4860A0AA98A50D(NULL);
		__this->___dpi_10 = il2cpp_codegen_cast_double_to_int<int32_t>(L_11);
		// language = GetISOCodeFromLangStruct(Application.systemLanguage);
		int32_t L_12;
		L_12 = Application_get_systemLanguage_mF0C8FBE854F7B58315A61087619DD10CB53A9AFF(NULL);
		String_t* L_13;
		L_13 = UnityAttributes_GetISOCodeFromLangStruct_m476952E31CCED8A496E40D5D10B900A0768A8CCD(__this, L_12, NULL);
		__this->___language_11 = L_13;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___language_11), (void*)L_13);
		// appName = Application.identifier;
		String_t* L_14;
		L_14 = Application_get_identifier_m26B38D49FA10A46D61C1309769A59E9CF7460006(NULL);
		__this->___appName_12 = L_14;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___appName_12), (void*)L_14);
		// appInstallMode = Application.installMode.ToString();
		int32_t L_15;
		L_15 = Application_get_installMode_mFE49B5A5A95880484D03C42020D3557B3632F168(NULL);
		V_1 = L_15;
		Il2CppFakeBox<int32_t> L_16(ApplicationInstallMode_tC04028D1A53D6C33BFE4678D81B891F6214C7CDA_il2cpp_TypeInfo_var, (&V_1));
		String_t* L_17;
		L_17 = Enum_ToString_m946B0B83C4470457D0FF555D862022C72BB55741((Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2*)(&L_16), NULL);
		__this->___appInstallMode_13 = L_17;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___appInstallMode_13), (void*)L_17);
		// appInstallStore = Application.installerName;
		String_t* L_18;
		L_18 = Application_get_installerName_m6664FDA245FFA5B28B2C91E3D27547310FE5A37A(NULL);
		__this->___appInstallStore_14 = L_18;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___appInstallStore_14), (void*)L_18);
		// graphicsDeviceId = SystemInfo.graphicsDeviceID;
		int32_t L_19;
		L_19 = SystemInfo_get_graphicsDeviceID_mE5A03FCF2980DDC6C95486C950B77B94B06B2520(NULL);
		__this->___graphicsDeviceId_15 = L_19;
		// graphicsDeviceVendorId = SystemInfo.graphicsDeviceVendorID;
		int32_t L_20;
		L_20 = SystemInfo_get_graphicsDeviceVendorID_m68EB5BF8E909EB60168504F3C894DCD9DF07D8D3(NULL);
		__this->___graphicsDeviceVendorId_16 = L_20;
		// graphicsName = SystemInfo.graphicsDeviceName;
		String_t* L_21;
		L_21 = SystemInfo_get_graphicsDeviceName_m29D97187ADB983D77438384BBD77F0BC48731122(NULL);
		__this->___graphicsName_17 = L_21;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___graphicsName_17), (void*)L_21);
		// graphicsDeviceVendor = SystemInfo.graphicsDeviceVendor;
		String_t* L_22;
		L_22 = SystemInfo_get_graphicsDeviceVendor_m83FB2B269311C74F8B6A1EF00C0502FA3E30CD98(NULL);
		__this->___graphicsDeviceVendor_18 = L_22;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___graphicsDeviceVendor_18), (void*)L_22);
		// graphicsVersion = SystemInfo.graphicsDeviceVersion;
		String_t* L_23;
		L_23 = SystemInfo_get_graphicsDeviceVersion_m3BD3A18E1F8A3F88D9022A01E0B39E13B9392F4B(NULL);
		__this->___graphicsVersion_19 = L_23;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___graphicsVersion_19), (void*)L_23);
		// graphicsShader = SystemInfo.graphicsShaderLevel;
		int32_t L_24;
		L_24 = SystemInfo_get_graphicsShaderLevel_mA9BA383B643FD022F8AFAF445B63B6554D88D27C(NULL);
		__this->___graphicsShader_20 = L_24;
		// maxTextureSize = SystemInfo.maxTextureSize;
		int32_t L_25;
		L_25 = SystemInfo_get_maxTextureSize_mB4272D4D85179CEF11FF1CDB3E8F3786D10CA04E(NULL);
		__this->___maxTextureSize_21 = L_25;
		// }
		return;
	}
}
// System.String Unity.RemoteConfig.UnityAttributes::GetDeviceModel()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityAttributes_GetDeviceModel_mE18196FBE4733B5F7F8DAFE82FAEB2ED8DE5C071 (UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaClass_tE6296B30CC4BF84434A9B765267F3FD0DD8DDB03_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_GetStatic_TisString_t_mF408A1C0C6E5BF8154F00A450A97A51B2ABFCBDE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2857526C6CA87F5E42495CA8FC55534F69207042);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3DF22942163DC77B0DAEE048614E29D96E4493DC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4A25544E6922FB90F714C62E18485457D83197D5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral59C3175CF396D80239CBF63054A92BA6236C8CD2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA929F9B4FD405482CE681D9E9297AF08F5469025);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	String_t* V_1 = NULL;
	String_t* V_2 = NULL;
	{
		// AndroidJavaClass jc = new AndroidJavaClass("android.os.Build");
		AndroidJavaClass_tE6296B30CC4BF84434A9B765267F3FD0DD8DDB03* L_0 = (AndroidJavaClass_tE6296B30CC4BF84434A9B765267F3FD0DD8DDB03*)il2cpp_codegen_object_new(AndroidJavaClass_tE6296B30CC4BF84434A9B765267F3FD0DD8DDB03_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		AndroidJavaClass__ctor_mB5466169E1151B8CC44C8FED234D79984B431389(L_0, _stringLiteral4A25544E6922FB90F714C62E18485457D83197D5, NULL);
		// string manufacturer = jc.GetStatic<string>("MANUFACTURER");
		AndroidJavaClass_tE6296B30CC4BF84434A9B765267F3FD0DD8DDB03* L_1 = L_0;
		NullCheck(L_1);
		String_t* L_2;
		L_2 = AndroidJavaObject_GetStatic_TisString_t_mF408A1C0C6E5BF8154F00A450A97A51B2ABFCBDE(L_1, _stringLiteral59C3175CF396D80239CBF63054A92BA6236C8CD2, AndroidJavaObject_GetStatic_TisString_t_mF408A1C0C6E5BF8154F00A450A97A51B2ABFCBDE_RuntimeMethod_var);
		V_0 = L_2;
		// string model = jc.GetStatic<string>("MODEL");
		AndroidJavaClass_tE6296B30CC4BF84434A9B765267F3FD0DD8DDB03* L_3 = L_1;
		NullCheck(L_3);
		String_t* L_4;
		L_4 = AndroidJavaObject_GetStatic_TisString_t_mF408A1C0C6E5BF8154F00A450A97A51B2ABFCBDE(L_3, _stringLiteral2857526C6CA87F5E42495CA8FC55534F69207042, AndroidJavaObject_GetStatic_TisString_t_mF408A1C0C6E5BF8154F00A450A97A51B2ABFCBDE_RuntimeMethod_var);
		V_1 = L_4;
		// string device = jc.GetStatic<string>("DEVICE");
		NullCheck(L_3);
		String_t* L_5;
		L_5 = AndroidJavaObject_GetStatic_TisString_t_mF408A1C0C6E5BF8154F00A450A97A51B2ABFCBDE(L_3, _stringLiteral3DF22942163DC77B0DAEE048614E29D96E4493DC, AndroidJavaObject_GetStatic_TisString_t_mF408A1C0C6E5BF8154F00A450A97A51B2ABFCBDE_RuntimeMethod_var);
		V_2 = L_5;
		// return string.Format("{0}/{1}/{2}", manufacturer, model, device);
		String_t* L_6 = V_0;
		String_t* L_7 = V_1;
		String_t* L_8 = V_2;
		String_t* L_9;
		L_9 = String_Format_m76BF8F3A6AD789E38B708848A2688D400AAC250A(_stringLiteralA929F9B4FD405482CE681D9E9297AF08F5469025, L_6, L_7, L_8, NULL);
		return L_9;
	}
}
// System.String Unity.RemoteConfig.UnityAttributes::GetISOCodeFromLangStruct(UnityEngine.SystemLanguage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityAttributes_GetISOCodeFromLangStruct_m476952E31CCED8A496E40D5D10B900A0768A8CCD (UnityAttributes_tDD2A3083AB93C90FE2CE896E0957B6A173DAAD04* __this, int32_t ___systemLanguage0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral09DBABCF47D177922630CF7626523A2E035CFB16);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0C45DB50527FCFAD456E74EB416B617329505309);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral17A5AD13F3B52AA01A6CBB2F9F414BE34E8AB9A9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1B62E5629805E3224249BCAA0D9ECBB4C84AE48B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral203DD5C89072A85E4D8D935A3028CCC3E3855F85);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral220702BCC5C1C54BEDED83D77E4E5425AFBCE65C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2BAE1EC4AD1D2DAA7FBBE5C17BB3EC9CC7AB734A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral35B44AA64754DEDC52915E7F763C081CF5B004D9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4B0E509E3481549FC8F096287EFB425FAAFC38A4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral561357A43AFC43D221B9F230B04E836DD73101EB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral68475E64D3943C9BB7F5E25BD175FCA30A7BAB36);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6B888C10342DD1C8AE97657EEA10E4A180B3258E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6BF72B6E90E497119B7EEA6511CFEB06890528B4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6DB33ADD301402F08747C4EE933A8EF10A8128F7);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral77EE5971434CDE6F74A1DAE44D94954E1624D77C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7BFA33A11F0B12AF1B7FA1D9BA996EAE1EF77B49);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7D63FA1B6FEDA67964D3FCDCB12764101D65571C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7D8699446610575017F99BEA3E02DCF807B45CAB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral824A9D9A2BAC4D0020E78F328C3A5908C950B369);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral82F3BE480580F58EE08D437D524BB2A9AD438EE4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8D927104AAFE48366762B70DC5E7CA34D1C0D5BE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral903B8C1EF36009AA876A865426B6853A18141FFA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral91C5120C562094A257C8FC3C676B64F1E0403765);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral96681A2B198D42859DB500CC97021274BD2004F1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral996E5360F80E16B2189CC1E536C91CE68083F694);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9FCE27425740686001DEDF0E34460EF2890AB0C3);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA31F29C367D53AD7C824C843BE0DEB228E4B5EBC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA3DC94CE2E4ADB08254413E0E3386625CB614D76);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB5965463376BB283A639934AF66DD9F2A1A062AA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBD150095AD1723163A0791D57A71CFF29421A88E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC295AE7F3D676E2CAA3DE0DC641EF335E57A2E37);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC3EC0475D7BECB6F89847EE0E364B00D04507118);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC4729ED69061AF5587EABEA577EE432AC85A94DB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC6DE535D828F30C374EB3BE3FFDE520228FC3096);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD5B20EA6805F285482807C61CD81D1509724E3CC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD744E0023ACB34526A1B142EFA90B5CFF45FDC53);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDC4A06A0DE599F745DBDD44A6FDE6212859D3A5F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDE923A0A39342ECBAD1253F5A36CD36E9E72666D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEAA0AD4C9DDC7B173ACD12710BBE084A3B32C5F6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFA3B5499785CBEEA66513CEE09402FBF10AF5FBF);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___systemLanguage0;
		switch (L_0)
		{
			case 0:
			{
				goto IL_00b7;
			}
			case 1:
			{
				goto IL_00bd;
			}
			case 2:
			{
				goto IL_00c3;
			}
			case 3:
			{
				goto IL_00c9;
			}
			case 4:
			{
				goto IL_00cf;
			}
			case 5:
			{
				goto IL_00d5;
			}
			case 6:
			{
				goto IL_00db;
			}
			case 7:
			{
				goto IL_00e1;
			}
			case 8:
			{
				goto IL_00e7;
			}
			case 9:
			{
				goto IL_00ed;
			}
			case 10:
			{
				goto IL_00f3;
			}
			case 11:
			{
				goto IL_00f9;
			}
			case 12:
			{
				goto IL_00ff;
			}
			case 13:
			{
				goto IL_0105;
			}
			case 14:
			{
				goto IL_010b;
			}
			case 15:
			{
				goto IL_0111;
			}
			case 16:
			{
				goto IL_0117;
			}
			case 17:
			{
				goto IL_011d;
			}
			case 18:
			{
				goto IL_0123;
			}
			case 19:
			{
				goto IL_0129;
			}
			case 20:
			{
				goto IL_012f;
			}
			case 21:
			{
				goto IL_0135;
			}
			case 22:
			{
				goto IL_013b;
			}
			case 23:
			{
				goto IL_0141;
			}
			case 24:
			{
				goto IL_0147;
			}
			case 25:
			{
				goto IL_014d;
			}
			case 26:
			{
				goto IL_0153;
			}
			case 27:
			{
				goto IL_0159;
			}
			case 28:
			{
				goto IL_015f;
			}
			case 29:
			{
				goto IL_0165;
			}
			case 30:
			{
				goto IL_016b;
			}
			case 31:
			{
				goto IL_0171;
			}
			case 32:
			{
				goto IL_0177;
			}
			case 33:
			{
				goto IL_017d;
			}
			case 34:
			{
				goto IL_0183;
			}
			case 35:
			{
				goto IL_0189;
			}
			case 36:
			{
				goto IL_018f;
			}
			case 37:
			{
				goto IL_0195;
			}
			case 38:
			{
				goto IL_019b;
			}
			case 39:
			{
				goto IL_01a7;
			}
			case 40:
			{
				goto IL_00db;
			}
			case 41:
			{
				goto IL_00db;
			}
			case 42:
			{
				goto IL_01a1;
			}
		}
	}
	{
		goto IL_01ad;
	}

IL_00b7:
	{
		// return "af";
		return _stringLiteralDE923A0A39342ECBAD1253F5A36CD36E9E72666D;
	}

IL_00bd:
	{
		// return "ar";
		return _stringLiteral903B8C1EF36009AA876A865426B6853A18141FFA;
	}

IL_00c3:
	{
		// return "eu";
		return _stringLiteral6B888C10342DD1C8AE97657EEA10E4A180B3258E;
	}

IL_00c9:
	{
		// return "be";
		return _stringLiteralB5965463376BB283A639934AF66DD9F2A1A062AA;
	}

IL_00cf:
	{
		// return "bg";
		return _stringLiteral96681A2B198D42859DB500CC97021274BD2004F1;
	}

IL_00d5:
	{
		// return "ca";
		return _stringLiteralBD150095AD1723163A0791D57A71CFF29421A88E;
	}

IL_00db:
	{
		// return "zh";
		return _stringLiteralEAA0AD4C9DDC7B173ACD12710BBE084A3B32C5F6;
	}

IL_00e1:
	{
		// return "cs";
		return _stringLiteral9FCE27425740686001DEDF0E34460EF2890AB0C3;
	}

IL_00e7:
	{
		// return "da";
		return _stringLiteral7D8699446610575017F99BEA3E02DCF807B45CAB;
	}

IL_00ed:
	{
		// return "nl";
		return _stringLiteral6DB33ADD301402F08747C4EE933A8EF10A8128F7;
	}

IL_00f3:
	{
		// return "en";
		return _stringLiteralC6DE535D828F30C374EB3BE3FFDE520228FC3096;
	}

IL_00f9:
	{
		// return "et";
		return _stringLiteralD5B20EA6805F285482807C61CD81D1509724E3CC;
	}

IL_00ff:
	{
		// return "fo";
		return _stringLiteral6BF72B6E90E497119B7EEA6511CFEB06890528B4;
	}

IL_0105:
	{
		// return "fi";
		return _stringLiteral91C5120C562094A257C8FC3C676B64F1E0403765;
	}

IL_010b:
	{
		// return "fr";
		return _stringLiteral203DD5C89072A85E4D8D935A3028CCC3E3855F85;
	}

IL_0111:
	{
		// return "de";
		return _stringLiteralDC4A06A0DE599F745DBDD44A6FDE6212859D3A5F;
	}

IL_0117:
	{
		// return "el";
		return _stringLiteral561357A43AFC43D221B9F230B04E836DD73101EB;
	}

IL_011d:
	{
		// return "he";
		return _stringLiteral7D63FA1B6FEDA67964D3FCDCB12764101D65571C;
	}

IL_0123:
	{
		// return "hu";
		return _stringLiteral220702BCC5C1C54BEDED83D77E4E5425AFBCE65C;
	}

IL_0129:
	{
		// return "is";
		return _stringLiteralC3EC0475D7BECB6F89847EE0E364B00D04507118;
	}

IL_012f:
	{
		// return "id";
		return _stringLiteral996E5360F80E16B2189CC1E536C91CE68083F694;
	}

IL_0135:
	{
		// return "it";
		return _stringLiteral1B62E5629805E3224249BCAA0D9ECBB4C84AE48B;
	}

IL_013b:
	{
		// return "ja";
		return _stringLiteral0C45DB50527FCFAD456E74EB416B617329505309;
	}

IL_0141:
	{
		// return "ko";
		return _stringLiteral4B0E509E3481549FC8F096287EFB425FAAFC38A4;
	}

IL_0147:
	{
		// return "lv";
		return _stringLiteralFA3B5499785CBEEA66513CEE09402FBF10AF5FBF;
	}

IL_014d:
	{
		// return "lt";
		return _stringLiteral35B44AA64754DEDC52915E7F763C081CF5B004D9;
	}

IL_0153:
	{
		// return "no";
		return _stringLiteral7BFA33A11F0B12AF1B7FA1D9BA996EAE1EF77B49;
	}

IL_0159:
	{
		// return "pl";
		return _stringLiteralD744E0023ACB34526A1B142EFA90B5CFF45FDC53;
	}

IL_015f:
	{
		// return "pt";
		return _stringLiteral17A5AD13F3B52AA01A6CBB2F9F414BE34E8AB9A9;
	}

IL_0165:
	{
		// return "ro";
		return _stringLiteral09DBABCF47D177922630CF7626523A2E035CFB16;
	}

IL_016b:
	{
		// return "ru";
		return _stringLiteralC295AE7F3D676E2CAA3DE0DC641EF335E57A2E37;
	}

IL_0171:
	{
		// return "sr";
		return _stringLiteral824A9D9A2BAC4D0020E78F328C3A5908C950B369;
	}

IL_0177:
	{
		// return "sk";
		return _stringLiteral82F3BE480580F58EE08D437D524BB2A9AD438EE4;
	}

IL_017d:
	{
		// return "sl";
		return _stringLiteralC4729ED69061AF5587EABEA577EE432AC85A94DB;
	}

IL_0183:
	{
		// return "es";
		return _stringLiteral77EE5971434CDE6F74A1DAE44D94954E1624D77C;
	}

IL_0189:
	{
		// return "sv";
		return _stringLiteralA3DC94CE2E4ADB08254413E0E3386625CB614D76;
	}

IL_018f:
	{
		// return "th";
		return _stringLiteral2BAE1EC4AD1D2DAA7FBBE5C17BB3EC9CC7AB734A;
	}

IL_0195:
	{
		// return "tk";
		return _stringLiteral68475E64D3943C9BB7F5E25BD175FCA30A7BAB36;
	}

IL_019b:
	{
		// return "uk";
		return _stringLiteralA31F29C367D53AD7C824C843BE0DEB228E4B5EBC;
	}

IL_01a1:
	{
		// return "en";
		return _stringLiteralC6DE535D828F30C374EB3BE3FFDE520228FC3096;
	}

IL_01a7:
	{
		// return "vi";
		return _stringLiteral8D927104AAFE48366762B70DC5E7CA34D1C0D5BE;
	}

IL_01ad:
	{
		// return "en";
		return _stringLiteralC6DE535D828F30C374EB3BE3FFDE520228FC3096;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Networking.UnityWebRequest Unity.RemoteConfig.RCUnityWebRequest::get__unityWebRequest()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// UnityWebRequest _unityWebRequest { get; set; }
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0 = __this->___U3C_unityWebRequestU3Ek__BackingField_0;
		return L_0;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set__unityWebRequest(UnityEngine.Networking.UnityWebRequest)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set__unityWebRequest_m7D0EA20714CEA31EC9033AD41B64EABC892B3D2F (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* ___value0, const RuntimeMethod* method) 
{
	{
		// UnityWebRequest _unityWebRequest { get; set; }
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0 = ___value0;
		__this->___U3C_unityWebRequestU3Ek__BackingField_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3C_unityWebRequestU3Ek__BackingField_0), (void*)L_0);
		return;
	}
}
// System.Boolean Unity.RemoteConfig.RCUnityWebRequest::get_isHttpError()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RCUnityWebRequest_get_isHttpError_m39059FCA86A2638B07B4DCD731D849E1C2D5F96A (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// public bool isHttpError => _unityWebRequest.isHttpError;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		bool L_1;
		L_1 = UnityWebRequest_get_isHttpError_m945BA480A179E05CC9659846414D9521ED648ED5(L_0, NULL);
		return L_1;
	}
}
// System.Single Unity.RemoteConfig.RCUnityWebRequest::get_downloadProgress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float RCUnityWebRequest_get_downloadProgress_mE09ADE685E2BF46F94E1713A1C88D9DEB458F8F6 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// public float downloadProgress => _unityWebRequest.downloadProgress;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		float L_1;
		L_1 = UnityWebRequest_get_downloadProgress_m28B3DB759530A61929D8AB02A4482AB21D3348B1(L_0, NULL);
		return L_1;
	}
}
// System.UInt64 Unity.RemoteConfig.RCUnityWebRequest::get_uploadedBytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint64_t RCUnityWebRequest_get_uploadedBytes_mFF355BCBDCA5B35C659BABBDD9D52021A0215B01 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// public ulong uploadedBytes => _unityWebRequest.uploadedBytes;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		uint64_t L_1;
		L_1 = UnityWebRequest_get_uploadedBytes_mA1DA52CB702E41CB42D0A8809AA80D642976B0D4(L_0, NULL);
		return L_1;
	}
}
// System.UInt64 Unity.RemoteConfig.RCUnityWebRequest::get_downloadedBytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint64_t RCUnityWebRequest_get_downloadedBytes_m04D9ABD8E88945C04C7784DE7169CA8823EC5A27 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// public ulong downloadedBytes => _unityWebRequest.downloadedBytes;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		uint64_t L_1;
		L_1 = UnityWebRequest_get_downloadedBytes_m73E3EC726E417FC7F983FFEF9566CF380F322610(L_0, NULL);
		return L_1;
	}
}
// System.Int32 Unity.RemoteConfig.RCUnityWebRequest::get_redirectLimit()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RCUnityWebRequest_get_redirectLimit_mA7502897A7F6B5A2A5D3D2456A22C283CCB9B52B (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.redirectLimit;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = UnityWebRequest_get_redirectLimit_m309E1021E1F5FCF64FB13B77D6585F2405605E71(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_redirectLimit(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_redirectLimit_m76AB0F549B698400B2BB3034493D3540A697C17A (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, int32_t ___value0, const RuntimeMethod* method) 
{
	{
		// set => redirectLimit = value;
		int32_t L_0 = ___value0;
		RCUnityWebRequest_set_redirectLimit_m76AB0F549B698400B2BB3034493D3540A697C17A(__this, L_0, NULL);
		return;
	}
}
// System.Boolean Unity.RemoteConfig.RCUnityWebRequest::get_chunkedTransfer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RCUnityWebRequest_get_chunkedTransfer_mBE2BFB7CBE0DA503FE80E758FD2162488E833284 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.chunkedTransfer;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		bool L_1;
		L_1 = UnityWebRequest_get_chunkedTransfer_m3DF3181EE21AE9F74FE4C9F7E4192A3A8028AC0E(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_chunkedTransfer(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_chunkedTransfer_m6B69044F190F3964D48DCADBDD46B231F1B8E058 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, bool ___value0, const RuntimeMethod* method) 
{
	{
		// set => chunkedTransfer = value;
		bool L_0 = ___value0;
		RCUnityWebRequest_set_chunkedTransfer_m6B69044F190F3964D48DCADBDD46B231F1B8E058(__this, L_0, NULL);
		return;
	}
}
// System.Boolean Unity.RemoteConfig.RCUnityWebRequest::get_isDone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RCUnityWebRequest_get_isDone_m827283DB33ADBF9D43E1D07482D819047A25B145 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// public bool isDone => _unityWebRequest.isDone;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		bool L_1;
		L_1 = UnityWebRequest_get_isDone_m3079B53A1CAFD8D5B334C635761E7B7E10B14123(L_0, NULL);
		return L_1;
	}
}
// System.Boolean Unity.RemoteConfig.RCUnityWebRequest::get_isNetworkError()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RCUnityWebRequest_get_isNetworkError_mA50FE1FABEB036520818035F657E987E216719B8 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// public bool isNetworkError => _unityWebRequest.isNetworkError;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		bool L_1;
		L_1 = UnityWebRequest_get_isNetworkError_m036684411466688E71E67CDD3703BAC9035A56F0(L_0, NULL);
		return L_1;
	}
}
// System.String Unity.RemoteConfig.RCUnityWebRequest::get_url()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RCUnityWebRequest_get_url_mFD565DEBFBB712CEDB670739C4EFDAE7019F1B7A (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.url;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		String_t* L_1;
		L_1 = UnityWebRequest_get_url_mA3BF205A6FCA2BF66A62174182BE84553CE3FFA8(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_url(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_url_m75133D4C34C7305F8EED05A6B31A743A56D71899 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, String_t* ___value0, const RuntimeMethod* method) 
{
	{
		// set => _unityWebRequest.url = value;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		String_t* L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_url_m5C117F8E00BA03DDC9EBC859DCB31BB4B6E3ECFC(L_0, L_1, NULL);
		return;
	}
}
// System.Uri Unity.RemoteConfig.RCUnityWebRequest::get_uri()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E* RCUnityWebRequest_get_uri_m6D5CE9C2BADB7B87500A1F330DA73A95C0669C04 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.uri;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E* L_1;
		L_1 = UnityWebRequest_get_uri_m12BEAEDE0E840ABE7B4B69528EB756BDA423A8F9(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_uri(System.Uri)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_uri_m2389CA530E748FA50C95CF713C591235DA0DE5BD (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E* ___value0, const RuntimeMethod* method) 
{
	{
		// set => _unityWebRequest.uri = value;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		Uri_t1500A52B5F71A04F5D05C0852D0F2A0941842A0E* L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_uri_m273584DE722413D238FB04EA0AE5F35A580272C6(L_0, L_1, NULL);
		return;
	}
}
// System.Int64 Unity.RemoteConfig.RCUnityWebRequest::get_responseCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t RCUnityWebRequest_get_responseCode_m8DE3606E41F5F442938525167B8D7D8804B8EFF8 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// public long responseCode => _unityWebRequest.responseCode;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		int64_t L_1;
		L_1 = UnityWebRequest_get_responseCode_m012C177F61435D5D120A21D7A03FFF7B0F8B904B(L_0, NULL);
		return L_1;
	}
}
// System.Single Unity.RemoteConfig.RCUnityWebRequest::get_uploadProgress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float RCUnityWebRequest_get_uploadProgress_m49CAE7DC32E6F8927361DEF0DD3BE4FEA2184F7F (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// public float uploadProgress => _unityWebRequest.uploadProgress;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		float L_1;
		L_1 = UnityWebRequest_get_uploadProgress_m3D2DCD424E0435ABAC0F84EE857121E839652F95(L_0, NULL);
		return L_1;
	}
}
// System.Boolean Unity.RemoteConfig.RCUnityWebRequest::get_isModifiable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RCUnityWebRequest_get_isModifiable_mC875CB7FAAA3DDB984B4BADDD39D2E7F2BE6692E (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// public bool isModifiable => _unityWebRequest.isModifiable;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		bool L_1;
		L_1 = UnityWebRequest_get_isModifiable_m8B2DA7C5B43443C4262BB0289141A608E2695D77(L_0, NULL);
		return L_1;
	}
}
// System.Boolean Unity.RemoteConfig.RCUnityWebRequest::get_disposeUploadHandlerOnDispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RCUnityWebRequest_get_disposeUploadHandlerOnDispose_mFA4AF1C7BFAF3466F5CCD6E71B6F775A982120F0 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.disposeUploadHandlerOnDispose;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		bool L_1;
		L_1 = UnityWebRequest_get_disposeUploadHandlerOnDispose_m909CC9BEACAC26C87F44AA957B8F5E5CD10F5761_inline(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_disposeUploadHandlerOnDispose(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_disposeUploadHandlerOnDispose_m73925B8D45153C53F1E1530B3A5BB74261EE7AF4 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, bool ___value0, const RuntimeMethod* method) 
{
	{
		// set => _unityWebRequest.disposeUploadHandlerOnDispose = value;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		bool L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_disposeUploadHandlerOnDispose_mFE16234F005357FECF4A45F842D17C0C52B7CA6E_inline(L_0, L_1, NULL);
		return;
	}
}
// System.String Unity.RemoteConfig.RCUnityWebRequest::get_method()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RCUnityWebRequest_get_method_m6EB3DB05D8FA6F339F083F387938126936890667 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.method;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		String_t* L_1;
		L_1 = UnityWebRequest_get_method_mEA8B59A692AEF09BF469AB6A8B5A8F8C22435AB9(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_method(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_method_mF644FCA7FE27EAD29819E54765546CFCFA143394 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, String_t* ___value0, const RuntimeMethod* method) 
{
	{
		// set => _unityWebRequest.method = value;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		String_t* L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_method_m35F9B5C788C66EACF3FB36FA220AA6B6777CFE88(L_0, L_1, NULL);
		return;
	}
}
// System.String Unity.RemoteConfig.RCUnityWebRequest::get_error()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RCUnityWebRequest_get_error_mEED4D3E78101351CB6041E58B2D85FD4AF30549B (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// public string error => _unityWebRequest.error;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		String_t* L_1;
		L_1 = UnityWebRequest_get_error_m20A5D813ED59118B7AA1D1E2EB5250178B1F5B6F(L_0, NULL);
		return L_1;
	}
}
// System.Boolean Unity.RemoteConfig.RCUnityWebRequest::get_useHttpContinue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RCUnityWebRequest_get_useHttpContinue_m992F5CB3CB9A24B46F80DC77173FDBC1035059D7 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.useHttpContinue;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		bool L_1;
		L_1 = UnityWebRequest_get_useHttpContinue_m52F5E404A60E72AD0A6D348B39738CEE9CF2A542(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_useHttpContinue(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_useHttpContinue_m046C8EC49F6E41A36BDF9F37D01563FC20B57878 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, bool ___value0, const RuntimeMethod* method) 
{
	{
		// set => _unityWebRequest.useHttpContinue = value;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		bool L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_useHttpContinue_m69A9328F59DD88D26472A60530C42DB1D770571E(L_0, L_1, NULL);
		return;
	}
}
// UnityEngine.Networking.UnityWebRequest Unity.RemoteConfig.RCUnityWebRequest::get_unityWebRequest()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* RCUnityWebRequest_get_unityWebRequest_m45210AA8624A61035C75FE6B01B44362C552F1E9 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get { return _unityWebRequest; }
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		return L_0;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_unityWebRequest(UnityEngine.Networking.UnityWebRequest)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_unityWebRequest_mEDEA0F5931A89608EB82EDE6408C25BA6F809C11 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* ___value0, const RuntimeMethod* method) 
{
	{
		// set { _unityWebRequest = value; }
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0 = ___value0;
		RCUnityWebRequest_set__unityWebRequest_m7D0EA20714CEA31EC9033AD41B64EABC892B3D2F_inline(__this, L_0, NULL);
		// set { _unityWebRequest = value; }
		return;
	}
}
// System.Boolean Unity.RemoteConfig.RCUnityWebRequest::get_disposeCertificateHandlerOnDispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RCUnityWebRequest_get_disposeCertificateHandlerOnDispose_m683B7F00FD90F45EDE1E8B93B5C7448309C614DF (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.disposeCertificateHandlerOnDispose;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		bool L_1;
		L_1 = UnityWebRequest_get_disposeCertificateHandlerOnDispose_m5BF6519F2982ABA7912948690570F7729EDF25E9_inline(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_disposeCertificateHandlerOnDispose(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_disposeCertificateHandlerOnDispose_mDEEA99B09CC57008E1025C1BE144FBC4F0F057EE (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, bool ___value0, const RuntimeMethod* method) 
{
	{
		// set => _unityWebRequest.disposeCertificateHandlerOnDispose = value;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		bool L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_disposeCertificateHandlerOnDispose_m5EFCAF91A547716C4ACA5FB546E991B79E3D0E2A_inline(L_0, L_1, NULL);
		return;
	}
}
// System.Boolean Unity.RemoteConfig.RCUnityWebRequest::get_disposeDownloadHandlerOnDispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RCUnityWebRequest_get_disposeDownloadHandlerOnDispose_m5B95D83676D11A8C9F153CC1DD3B7346A4F50F7B (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.disposeDownloadHandlerOnDispose;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		bool L_1;
		L_1 = UnityWebRequest_get_disposeDownloadHandlerOnDispose_mA5E23BB2B931F6EF089C732D0E56E1B7F9FC1C54_inline(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_disposeDownloadHandlerOnDispose(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_disposeDownloadHandlerOnDispose_m097EE3B5D57B61F244CE063A614078D754816B42 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, bool ___value0, const RuntimeMethod* method) 
{
	{
		// set => _unityWebRequest.disposeDownloadHandlerOnDispose = value;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		bool L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_disposeDownloadHandlerOnDispose_m1BF640E233D231F8C0333864C0FE5D9E1DC2E7C6_inline(L_0, L_1, NULL);
		return;
	}
}
// UnityEngine.Networking.DownloadHandler Unity.RemoteConfig.RCUnityWebRequest::get_downloadHandler()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* RCUnityWebRequest_get_downloadHandler_mFD12B9B005ECD0E5DB8DED43970F986427B6D148 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get { return _unityWebRequest.downloadHandler; }
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* L_1;
		L_1 = UnityWebRequest_get_downloadHandler_m1AA91B23D9D594A4F4FE2975FC356C508528F1D5(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_downloadHandler(UnityEngine.Networking.DownloadHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_downloadHandler_m17CAEC803C5C70D872206FD3BE6271AC39102924 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* ___value0, const RuntimeMethod* method) 
{
	{
		// set { _unityWebRequest.downloadHandler = value; }
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		DownloadHandler_t1B56C7D3F65D97A1E4B566A14A1E783EA8AE4EBB* L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_downloadHandler_m6CB94492012097DFC44E5773D1A627753788292F(L_0, L_1, NULL);
		// set { _unityWebRequest.downloadHandler = value; }
		return;
	}
}
// UnityEngine.Networking.CertificateHandler Unity.RemoteConfig.RCUnityWebRequest::get_certificateHandler()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804* RCUnityWebRequest_get_certificateHandler_m4B2AA508B345BDA55592A56BF195E1D6D66D8FAE (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.certificateHandler;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804* L_1;
		L_1 = UnityWebRequest_get_certificateHandler_m928A7BE34EB3725EA1D977877B7362E813918D7D(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_certificateHandler(UnityEngine.Networking.CertificateHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_certificateHandler_m490DEDA0B271CBD95E76987BE70C60CC814E97E2 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804* ___value0, const RuntimeMethod* method) 
{
	{
		// set => _unityWebRequest.certificateHandler = value;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		CertificateHandler_t148B524FA5DB39F3ABADB181CD420FC505C33804* L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_certificateHandler_m4B4FA1E2F5FD0394D079CB711EB612F6A62458E2(L_0, L_1, NULL);
		return;
	}
}
// System.Int32 Unity.RemoteConfig.RCUnityWebRequest::get_timeout()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RCUnityWebRequest_get_timeout_m7B7C9324DE9615E9963559A2956CEBAB709340A7 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get => _unityWebRequest.timeout;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = UnityWebRequest_get_timeout_mE7983CCB87576C0BF53D22A6BC79AC5191BB4927(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_timeout(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_timeout_m4A61D4CC6F764D6AAC1117BCB8A066FE191F0B2F (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, int32_t ___value0, const RuntimeMethod* method) 
{
	{
		// set => _unityWebRequest.timeout = value;
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		int32_t L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_timeout_mE9C8169FA8CF1BE17E3D9FDACDC6E1A9508DF618(L_0, L_1, NULL);
		return;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_Dispose_m1731F33A0FA041A0E342C88B493B9EFE8DA3A70F (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// _unityWebRequest.Dispose();
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		UnityWebRequest_Dispose_m9F43494C0FEA530A97D3F2AF3D425CCC7670753A(L_0, NULL);
		// }
		return;
	}
}
// UnityEngine.Networking.UploadHandler Unity.RemoteConfig.RCUnityWebRequest::get_uploadHandler()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6* RCUnityWebRequest_get_uploadHandler_m64D68DD754ADF738B4D2D4B4BB97220AE98ABDDF (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// get { return _unityWebRequest.uploadHandler; }
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6* L_1;
		L_1 = UnityWebRequest_get_uploadHandler_mF92ED2E0410E7F720B8775B467CFD86B60909CF5(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::set_uploadHandler(UnityEngine.Networking.UploadHandler)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_set_uploadHandler_mCAC1021CD5A38F85FD3CC03EC5227562D385DE6D (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6* ___value0, const RuntimeMethod* method) 
{
	{
		// set { _unityWebRequest.uploadHandler = value; }
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		UploadHandler_t7E504B1A83346248A0C8C4AF73A893226CB83EF6* L_1 = ___value0;
		NullCheck(L_0);
		UnityWebRequest_set_uploadHandler_m68F346550136DE178C79238944985892196027FE(L_0, L_1, NULL);
		// set { _unityWebRequest.uploadHandler = value; }
		return;
	}
}
// UnityEngine.Networking.UnityWebRequestAsyncOperation Unity.RemoteConfig.RCUnityWebRequest::SendWebRequest()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C* RCUnityWebRequest_SendWebRequest_m45E3D6DB2C4C4EF78C6D48674D583CEC27D77683 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// return _unityWebRequest.SendWebRequest();
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C* L_1;
		L_1 = UnityWebRequest_SendWebRequest_mA3CD13983BAA5074A0640EDD661B1E46E6DB6C13(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::Abort()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_Abort_m1EF539CCD8A7AB54FE51F41FD5ADB5FC3518CEF9 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// _unityWebRequest.Abort();
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		UnityWebRequest_Abort_m466E8B88BC90F64CE614561BAA88B9412BDB7E8B(L_0, NULL);
		// }
		return;
	}
}
// System.String Unity.RemoteConfig.RCUnityWebRequest::GetRequestHeader(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RCUnityWebRequest_GetRequestHeader_mC77E739AE1FD35D134DBA4B56159A5F286C47057 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, String_t* ___name0, const RuntimeMethod* method) 
{
	{
		// return _unityWebRequest.GetRequestHeader(name);
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		String_t* L_1 = ___name0;
		NullCheck(L_0);
		String_t* L_2;
		L_2 = UnityWebRequest_GetRequestHeader_mEDAC73EA86F30AE1438EBD3452AA927359437076(L_0, L_1, NULL);
		return L_2;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::SetRequestHeader(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest_SetRequestHeader_m4FB2E5E9AB59662AA749545FB0CCAD944AFF504F (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, String_t* ___name0, String_t* ___value1, const RuntimeMethod* method) 
{
	{
		// _unityWebRequest.SetRequestHeader(name, value);
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		String_t* L_1 = ___name0;
		String_t* L_2 = ___value1;
		NullCheck(L_0);
		UnityWebRequest_SetRequestHeader_m099734EB787B7269B62AB2236A5A4F7D35AF8BC5(L_0, L_1, L_2, NULL);
		// }
		return;
	}
}
// System.String Unity.RemoteConfig.RCUnityWebRequest::GetResponseHeader(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RCUnityWebRequest_GetResponseHeader_mA635CECB09961A58F2577192552BEA561A22A31A (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, String_t* ___name0, const RuntimeMethod* method) 
{
	{
		// return _unityWebRequest.GetResponseHeader(name);
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		String_t* L_1 = ___name0;
		NullCheck(L_0);
		String_t* L_2;
		L_2 = UnityWebRequest_GetResponseHeader_m9AC0E1BB43CE0469BC7FE865B3D9B2C4198DDF03(L_0, L_1, NULL);
		return L_2;
	}
}
// System.Collections.Generic.Dictionary`2<System.String,System.String> Unity.RemoteConfig.RCUnityWebRequest::GetResponseHeaders()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* RCUnityWebRequest_GetResponseHeaders_mD82C15C8DCE779536154FABB25B151FB80F2992D (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// return _unityWebRequest.GetResponseHeaders();
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0;
		L_0 = RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline(__this, NULL);
		NullCheck(L_0);
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_1;
		L_1 = UnityWebRequest_GetResponseHeaders_m67147A5D3FF83FD75071AA42F4890439DA2092DF(L_0, NULL);
		return L_1;
	}
}
// System.Void Unity.RemoteConfig.RCUnityWebRequest::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RCUnityWebRequest__ctor_m87B241477692D8A5E928205EB7E3EBB215675576 (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Unity.RemoteConfig.ConfigOrigin Unity.RemoteConfig.RuntimeConfig::get_origin()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RuntimeConfig_get_origin_mBD94D1D4287F7D5048A48A77858C514E148608E6 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, const RuntimeMethod* method) 
{
	{
		// public ConfigOrigin origin { get; internal set; }
		int32_t L_0 = __this->___U3CoriginU3Ek__BackingField_0;
		return L_0;
	}
}
// System.Void Unity.RemoteConfig.RuntimeConfig::set_origin(Unity.RemoteConfig.ConfigOrigin)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig_set_origin_m6C14486843F6D9FF1EF6C632048897C7B99C6433 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, int32_t ___value0, const RuntimeMethod* method) 
{
	{
		// public ConfigOrigin origin { get; internal set; }
		int32_t L_0 = ___value0;
		__this->___U3CoriginU3Ek__BackingField_0 = L_0;
		return;
	}
}
// System.String Unity.RemoteConfig.RuntimeConfig::get_environmentId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RuntimeConfig_get_environmentId_m011FF43FA1D541F5CD073A45C306664C60F8E3AB (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, const RuntimeMethod* method) 
{
	{
		// public string environmentId { get; set; }
		String_t* L_0 = __this->___U3CenvironmentIdU3Ek__BackingField_1;
		return L_0;
	}
}
// System.Void Unity.RemoteConfig.RuntimeConfig::set_environmentId(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig_set_environmentId_mF086880C01CA1AEBBE02455AE3776D5D037ADFA4 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___value0, const RuntimeMethod* method) 
{
	{
		// public string environmentId { get; set; }
		String_t* L_0 = ___value0;
		__this->___U3CenvironmentIdU3Ek__BackingField_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CenvironmentIdU3Ek__BackingField_1), (void*)L_0);
		return;
	}
}
// System.String Unity.RemoteConfig.RuntimeConfig::get_assignmentId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RuntimeConfig_get_assignmentId_mB54AE46434BF4125683176CAB6C5FCF338DE74D4 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, const RuntimeMethod* method) 
{
	{
		// public string assignmentId { get; set; }
		String_t* L_0 = __this->___U3CassignmentIdU3Ek__BackingField_2;
		return L_0;
	}
}
// System.Void Unity.RemoteConfig.RuntimeConfig::set_assignmentId(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig_set_assignmentId_mD20089BCB060198D1BD6DB4C06EB3DFCCBABE510 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___value0, const RuntimeMethod* method) 
{
	{
		// public string assignmentId { get; set; }
		String_t* L_0 = ___value0;
		__this->___U3CassignmentIdU3Ek__BackingField_2 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CassignmentIdU3Ek__BackingField_2), (void*)L_0);
		return;
	}
}
// System.Void Unity.RemoteConfig.RuntimeConfig::add_FetchCompleted(System.Action`1<Unity.RemoteConfig.ConfigResponse>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig_add_FetchCompleted_mFDD787BA362A46B3C2CC3ED5B93D2007FC3C7338 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_0 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_1 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_2 = NULL;
	{
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_0 = __this->___FetchCompleted_8;
		V_0 = L_0;
	}

IL_0007:
	{
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_1 = V_0;
		V_1 = L_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_2 = V_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_3 = ___value0;
		Delegate_t* L_4;
		L_4 = Delegate_Combine_m8B9D24CED35033C7FC56501DFE650F5CB7FF012C(L_2, L_3, NULL);
		V_2 = ((Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)Castclass((RuntimeObject*)L_4, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var));
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E** L_5 = (&__this->___FetchCompleted_8);
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_6 = V_2;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_7 = V_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_8;
		L_8 = InterlockedCompareExchangeImpl<Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*>(L_5, L_6, L_7);
		V_0 = L_8;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_9 = V_0;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_10 = V_1;
		if ((!(((RuntimeObject*)(Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)L_9) == ((RuntimeObject*)(Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
// System.Void Unity.RemoteConfig.RuntimeConfig::remove_FetchCompleted(System.Action`1<Unity.RemoteConfig.ConfigResponse>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig_remove_FetchCompleted_m193774BB24681096DF02973B7F5F5B6A024F01AB (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_0 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_1 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* V_2 = NULL;
	{
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_0 = __this->___FetchCompleted_8;
		V_0 = L_0;
	}

IL_0007:
	{
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_1 = V_0;
		V_1 = L_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_2 = V_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_3 = ___value0;
		Delegate_t* L_4;
		L_4 = Delegate_Remove_m40506877934EC1AD4ADAE57F5E97AF0BC0F96116(L_2, L_3, NULL);
		V_2 = ((Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)Castclass((RuntimeObject*)L_4, Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E_il2cpp_TypeInfo_var));
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E** L_5 = (&__this->___FetchCompleted_8);
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_6 = V_2;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_7 = V_1;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_8;
		L_8 = InterlockedCompareExchangeImpl<Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*>(L_5, L_6, L_7);
		V_0 = L_8;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_9 = V_0;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_10 = V_1;
		if ((!(((RuntimeObject*)(Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)L_9) == ((RuntimeObject*)(Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E*)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
// Newtonsoft.Json.Linq.JObject Unity.RemoteConfig.RuntimeConfig::get_config()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* RuntimeConfig_get_config_m4C7EB5C4B6FD5D8135B68BC4F993D6E520F4E5FE (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return (JObject)_config.DeepClone();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_0 = __this->____config_6;
		NullCheck(L_0);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_1;
		L_1 = JToken_DeepClone_m9A8C76BD945F1D49D1778B032BE6CF75CB350A4B(L_0, NULL);
		return ((JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1*)CastclassClass((RuntimeObject*)L_1, JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var));
	}
}
// System.Void Unity.RemoteConfig.RuntimeConfig::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig__ctor_m86B59B69E6F3D781991235921A872D8362417EF7 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___configType0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// JsonSerializerSettings rawDateSettings = new JsonSerializerSettings { DateParseHandling = DateParseHandling.None };
		JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF* L_0 = (JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF*)il2cpp_codegen_object_new(JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		JsonSerializerSettings__ctor_mE1C9A90375BA88DF7F6911F1F96AEEC6A98CD22F(L_0, NULL);
		JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF* L_1 = L_0;
		NullCheck(L_1);
		JsonSerializerSettings_set_DateParseHandling_mB406892CFC183EC516945AB10AE3C8BF239A2698(L_1, 0, NULL);
		__this->___rawDateSettings_7 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___rawDateSettings_7), (void*)L_1);
		// internal RuntimeConfig(string configType)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// this.configType = configType;
		String_t* L_2 = ___configType0;
		__this->___configType_3 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___configType_3), (void*)L_2);
		// RequestStatus = ConfigRequestStatus.None;
		__this->___RequestStatus_5 = 0;
		// origin = ConfigOrigin.Default;
		RuntimeConfig_set_origin_m6C14486843F6D9FF1EF6C632048897C7B99C6433_inline(__this, 0, NULL);
		// _config = new JObject();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_3 = (JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1*)il2cpp_codegen_object_new(JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		JObject__ctor_mF7F801B6729F7309319FF97690BCC68C7CA81CE4(L_3, NULL);
		__this->____config_6 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____config_6), (void*)L_3);
		// ConfigResponse = new ConfigResponse();
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871* L_4 = (&__this->___ConfigResponse_4);
		il2cpp_codegen_initobj(L_4, sizeof(ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871));
		// }
		return;
	}
}
// System.Void Unity.RemoteConfig.RuntimeConfig::HandleConfigResponse(Unity.RemoteConfig.ConfigResponse)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeConfig_HandleConfigResponse_mF33BFEEFEA29FE9B434CFF49D921AA7305D1A021 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___configResponse0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_GetValueOrDefault_m7AFC352C983BBB73C8142843D7BA4ABBCDB8E67E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1__ctor_m52AD48CA918ECAA8E53A7DE5F83CA02AF3EA544B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_m062422AAA723286DD6D3FDEA566B13560D01CEEE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral07209D8AB943F98AB103AED7BA2AB574E0E5C0D2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral20BB23A674F385779F076FBBECD1E67230DE5751);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA56C9155AC403BB1318263AA70D1C16BBC8123D1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCD8C0871ADAE319947AA8BA890CC94E7926A9C70);
		s_Il2CppMethodInitialized = true;
	}
	JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* V_0 = NULL;
	Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB V_1;
	memset((&V_1), 0, sizeof(V_1));
	int32_t V_2 = 0;
	Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB V_3;
	memset((&V_3), 0, sizeof(V_3));
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B3_0 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B2_0 = NULL;
	int32_t G_B7_0 = 0;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B5_0 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B4_0 = NULL;
	Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB G_B6_0;
	memset((&G_B6_0), 0, sizeof(G_B6_0));
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B11_0 = NULL;
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* G_B11_1 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B10_0 = NULL;
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* G_B10_1 = NULL;
	String_t* G_B14_0 = NULL;
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* G_B14_1 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B13_0 = NULL;
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* G_B13_1 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B12_0 = NULL;
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* G_B12_1 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B16_0 = NULL;
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* G_B16_1 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B15_0 = NULL;
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* G_B15_1 = NULL;
	String_t* G_B19_0 = NULL;
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* G_B19_1 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B18_0 = NULL;
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* G_B18_1 = NULL;
	JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* G_B17_0 = NULL;
	RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* G_B17_1 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* G_B22_0 = NULL;
	Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* G_B21_0 = NULL;
	{
		// ConfigResponse = configResponse;
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_0 = ___configResponse0;
		__this->___ConfigResponse_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->___ConfigResponse_4))->___body_2), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&__this->___ConfigResponse_4))->___headers_3), (void*)NULL);
		#endif
		// RequestStatus = ConfigResponse.status;
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871* L_1 = (&__this->___ConfigResponse_4);
		int32_t L_2 = L_1->___status_1;
		__this->___RequestStatus_5 = L_2;
		// var responseBody = ConfigResponse.body;
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871* L_3 = (&__this->___ConfigResponse_4);
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_4 = L_3->___body_2;
		V_0 = L_4;
		// if(configResponse.status == ConfigRequestStatus.Success)
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_5 = ___configResponse0;
		int32_t L_6 = L_5.___status_1;
		if ((!(((uint32_t)L_6) == ((uint32_t)2))))
		{
			goto IL_010a;
		}
	}
	{
		// if (responseBody["configs"]?[configType]?.Type != JTokenType.Object) return;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_7 = V_0;
		NullCheck(L_7);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_8;
		L_8 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_7, _stringLiteral07209D8AB943F98AB103AED7BA2AB574E0E5C0D2, NULL);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_9 = L_8;
		G_B2_0 = L_9;
		if (L_9)
		{
			G_B3_0 = L_9;
			goto IL_0042;
		}
	}
	{
		G_B7_0 = 1;
		goto IL_007e;
	}

IL_0042:
	{
		String_t* L_10 = __this->___configType_3;
		NullCheck(G_B3_0);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_11;
		L_11 = VirtualFuncInvoker1< JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3*, RuntimeObject* >::Invoke(17 /* Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JToken::get_Item(System.Object) */, G_B3_0, L_10);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_12 = L_11;
		G_B4_0 = L_12;
		if (L_12)
		{
			G_B5_0 = L_12;
			goto IL_005c;
		}
	}
	{
		il2cpp_codegen_initobj((&V_3), sizeof(Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB));
		Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB L_13 = V_3;
		G_B6_0 = L_13;
		goto IL_0066;
	}

IL_005c:
	{
		NullCheck(G_B5_0);
		int32_t L_14;
		L_14 = VirtualFuncInvoker0< int32_t >::Invoke(15 /* Newtonsoft.Json.Linq.JTokenType Newtonsoft.Json.Linq.JToken::get_Type() */, G_B5_0);
		Nullable_1_t98A9DFD38F91A6E94A91C0EA86F332B55B6499CB L_15;
		memset((&L_15), 0, sizeof(L_15));
		Nullable_1__ctor_m52AD48CA918ECAA8E53A7DE5F83CA02AF3EA544B((&L_15), L_14, /*hidden argument*/Nullable_1__ctor_m52AD48CA918ECAA8E53A7DE5F83CA02AF3EA544B_RuntimeMethod_var);
		G_B6_0 = L_15;
	}

IL_0066:
	{
		V_1 = G_B6_0;
		V_2 = 1;
		int32_t L_16;
		L_16 = Nullable_1_GetValueOrDefault_m7AFC352C983BBB73C8142843D7BA4ABBCDB8E67E_inline((&V_1), Nullable_1_GetValueOrDefault_m7AFC352C983BBB73C8142843D7BA4ABBCDB8E67E_RuntimeMethod_var);
		int32_t L_17 = V_2;
		bool L_18;
		L_18 = Nullable_1_get_HasValue_m062422AAA723286DD6D3FDEA566B13560D01CEEE_inline((&V_1), Nullable_1_get_HasValue_m062422AAA723286DD6D3FDEA566B13560D01CEEE_RuntimeMethod_var);
		G_B7_0 = ((((int32_t)((int32_t)(((((int32_t)L_16) == ((int32_t)L_17))? 1 : 0)&(int32_t)L_18))) == ((int32_t)0))? 1 : 0);
	}

IL_007e:
	{
		if (!G_B7_0)
		{
			goto IL_0081;
		}
	}
	{
		// if (responseBody["configs"]?[configType]?.Type != JTokenType.Object) return;
		return;
	}

IL_0081:
	{
		// _config = (JObject) responseBody["configs"][configType];
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_19 = V_0;
		NullCheck(L_19);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_20;
		L_20 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_19, _stringLiteral07209D8AB943F98AB103AED7BA2AB574E0E5C0D2, NULL);
		String_t* L_21 = __this->___configType_3;
		NullCheck(L_20);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_22;
		L_22 = VirtualFuncInvoker1< JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3*, RuntimeObject* >::Invoke(17 /* Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JToken::get_Item(System.Object) */, L_20, L_21);
		__this->____config_6 = ((JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1*)CastclassClass((RuntimeObject*)L_22, JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var));
		Il2CppCodeGenWriteBarrier((void**)(&__this->____config_6), (void*)((JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1*)CastclassClass((RuntimeObject*)L_22, JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1_il2cpp_TypeInfo_var)));
		// origin = configResponse.requestOrigin;
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_23 = ___configResponse0;
		int32_t L_24 = L_23.___requestOrigin_0;
		RuntimeConfig_set_origin_m6C14486843F6D9FF1EF6C632048897C7B99C6433_inline(__this, L_24, NULL);
		// environmentId = responseBody["metadata"]?["environmentId"]?.ToString();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_25 = V_0;
		NullCheck(L_25);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_26;
		L_26 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_25, _stringLiteral20BB23A674F385779F076FBBECD1E67230DE5751, NULL);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_27 = L_26;
		G_B10_0 = L_27;
		G_B10_1 = __this;
		if (L_27)
		{
			G_B11_0 = L_27;
			G_B11_1 = __this;
			goto IL_00c1;
		}
	}
	{
		G_B14_0 = ((String_t*)(NULL));
		G_B14_1 = G_B10_1;
		goto IL_00d7;
	}

IL_00c1:
	{
		NullCheck(G_B11_0);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_28;
		L_28 = VirtualFuncInvoker1< JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3*, RuntimeObject* >::Invoke(17 /* Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JToken::get_Item(System.Object) */, G_B11_0, _stringLiteralCD8C0871ADAE319947AA8BA890CC94E7926A9C70);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_29 = L_28;
		G_B12_0 = L_29;
		G_B12_1 = G_B11_1;
		if (L_29)
		{
			G_B13_0 = L_29;
			G_B13_1 = G_B11_1;
			goto IL_00d2;
		}
	}
	{
		G_B14_0 = ((String_t*)(NULL));
		G_B14_1 = G_B12_1;
		goto IL_00d7;
	}

IL_00d2:
	{
		NullCheck(G_B13_0);
		String_t* L_30;
		L_30 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B13_0);
		G_B14_0 = L_30;
		G_B14_1 = G_B13_1;
	}

IL_00d7:
	{
		NullCheck(G_B14_1);
		RuntimeConfig_set_environmentId_mF086880C01CA1AEBBE02455AE3776D5D037ADFA4_inline(G_B14_1, G_B14_0, NULL);
		// assignmentId = responseBody["metadata"]?["assignmentId"]?.ToString();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_31 = V_0;
		NullCheck(L_31);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_32;
		L_32 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_31, _stringLiteral20BB23A674F385779F076FBBECD1E67230DE5751, NULL);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_33 = L_32;
		G_B15_0 = L_33;
		G_B15_1 = __this;
		if (L_33)
		{
			G_B16_0 = L_33;
			G_B16_1 = __this;
			goto IL_00ef;
		}
	}
	{
		G_B19_0 = ((String_t*)(NULL));
		G_B19_1 = G_B15_1;
		goto IL_0105;
	}

IL_00ef:
	{
		NullCheck(G_B16_0);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_34;
		L_34 = VirtualFuncInvoker1< JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3*, RuntimeObject* >::Invoke(17 /* Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JToken::get_Item(System.Object) */, G_B16_0, _stringLiteralA56C9155AC403BB1318263AA70D1C16BBC8123D1);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_35 = L_34;
		G_B17_0 = L_35;
		G_B17_1 = G_B16_1;
		if (L_35)
		{
			G_B18_0 = L_35;
			G_B18_1 = G_B16_1;
			goto IL_0100;
		}
	}
	{
		G_B19_0 = ((String_t*)(NULL));
		G_B19_1 = G_B17_1;
		goto IL_0105;
	}

IL_0100:
	{
		NullCheck(G_B18_0);
		String_t* L_36;
		L_36 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B18_0);
		G_B19_0 = L_36;
		G_B19_1 = G_B18_1;
	}

IL_0105:
	{
		NullCheck(G_B19_1);
		RuntimeConfig_set_assignmentId_mD20089BCB060198D1BD6DB4C06EB3DFCCBABE510_inline(G_B19_1, G_B19_0, NULL);
	}

IL_010a:
	{
		// FetchCompleted?.Invoke(ConfigResponse);
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_37 = __this->___FetchCompleted_8;
		Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* L_38 = L_37;
		G_B21_0 = L_38;
		if (L_38)
		{
			G_B22_0 = L_38;
			goto IL_0115;
		}
	}
	{
		return;
	}

IL_0115:
	{
		ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 L_39 = __this->___ConfigResponse_4;
		NullCheck(G_B22_0);
		Action_1_Invoke_m496875C3D21245101D0AC44B050159FC1FBFB390_inline(G_B22_0, L_39, NULL);
		// }
		return;
	}
}
// System.Boolean Unity.RemoteConfig.RuntimeConfig::GetBool(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RuntimeConfig_GetBool_m8749C3CE7852E99E8632FCC8A87CB6CA789A7CFB (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___key0, bool ___defaultValue1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Extensions_Value_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m1DB6D797C74FDFDDAC6548EE8EA80DD90E9430A3_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		// return _config[key].Value<bool>();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_0 = __this->____config_6;
		String_t* L_1 = ___key0;
		NullCheck(L_0);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_2;
		L_2 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_0, L_1, NULL);
		bool L_3;
		L_3 = Extensions_Value_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m1DB6D797C74FDFDDAC6548EE8EA80DD90E9430A3(L_2, Extensions_Value_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_m1DB6D797C74FDFDDAC6548EE8EA80DD90E9430A3_RuntimeMethod_var);
		V_0 = L_3;
		goto IL_0019;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0014;
		}
		throw e;
	}

CATCH_0014:
	{// begin catch(System.Object)
		// catch
		// return defaultValue;
		bool L_4 = ___defaultValue1;
		V_0 = L_4;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0019;
	}// end catch (depth: 1)

IL_0019:
	{
		// }
		bool L_5 = V_0;
		return L_5;
	}
}
// System.Single Unity.RemoteConfig.RuntimeConfig::GetFloat(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float RuntimeConfig_GetFloat_mDDA65681E548DF83FB26762EF29F319FF56B9730 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___key0, float ___defaultValue1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Extensions_Value_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_mC5F3E49729A00991AFA91AC1F88BD187279B96AE_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		// return _config[key].Value<float>();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_0 = __this->____config_6;
		String_t* L_1 = ___key0;
		NullCheck(L_0);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_2;
		L_2 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_0, L_1, NULL);
		float L_3;
		L_3 = Extensions_Value_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_mC5F3E49729A00991AFA91AC1F88BD187279B96AE(L_2, Extensions_Value_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_mC5F3E49729A00991AFA91AC1F88BD187279B96AE_RuntimeMethod_var);
		V_0 = L_3;
		goto IL_0019;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0014;
		}
		throw e;
	}

CATCH_0014:
	{// begin catch(System.Object)
		// catch
		// return defaultValue;
		float L_4 = ___defaultValue1;
		V_0 = L_4;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0019;
	}// end catch (depth: 1)

IL_0019:
	{
		// }
		float L_5 = V_0;
		return L_5;
	}
}
// System.Int32 Unity.RemoteConfig.RuntimeConfig::GetInt(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RuntimeConfig_GetInt_mDD745B0BD73C249AE1FA3089391F78130570AA6F (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___key0, int32_t ___defaultValue1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Extensions_Value_TisInt32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_m3092267C93448D476CE9F21D518B204704D234B8_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		// return _config[key].Value<int>();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_0 = __this->____config_6;
		String_t* L_1 = ___key0;
		NullCheck(L_0);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_2;
		L_2 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_0, L_1, NULL);
		int32_t L_3;
		L_3 = Extensions_Value_TisInt32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_m3092267C93448D476CE9F21D518B204704D234B8(L_2, Extensions_Value_TisInt32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_m3092267C93448D476CE9F21D518B204704D234B8_RuntimeMethod_var);
		V_0 = L_3;
		goto IL_0019;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0014;
		}
		throw e;
	}

CATCH_0014:
	{// begin catch(System.Object)
		// catch
		// return defaultValue;
		int32_t L_4 = ___defaultValue1;
		V_0 = L_4;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0019;
	}// end catch (depth: 1)

IL_0019:
	{
		// }
		int32_t L_5 = V_0;
		return L_5;
	}
}
// System.String Unity.RemoteConfig.RuntimeConfig::GetString(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RuntimeConfig_GetString_m16A1F304A5C137388097EEFE5447BFADCC08B9D6 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___key0, String_t* ___defaultValue1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Extensions_Value_TisString_t_m2497E7CEFECAA73AFA2AC29B672F29E6489E1D30_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JsonConvert_t01281FFED14CC2AEFABB6608315D90ED5C46E0C2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D V_1;
	memset((&V_1), 0, sizeof(V_1));
	String_t* V_2 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	String_t* G_B3_0 = NULL;
	try
	{// begin try (depth: 1)
		{
			// var formattedInputString = string.IsNullOrEmpty(_config[key].Value<string>()) ? "" : _config[key].Value<string>();
			JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_0 = __this->____config_6;
			String_t* L_1 = ___key0;
			NullCheck(L_0);
			JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_2;
			L_2 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_0, L_1, NULL);
			String_t* L_3;
			L_3 = Extensions_Value_TisString_t_m2497E7CEFECAA73AFA2AC29B672F29E6489E1D30(L_2, Extensions_Value_TisString_t_m2497E7CEFECAA73AFA2AC29B672F29E6489E1D30_RuntimeMethod_var);
			bool L_4;
			L_4 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_3, NULL);
			if (L_4)
			{
				goto IL_002b_1;
			}
		}
		{
			JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_5 = __this->____config_6;
			String_t* L_6 = ___key0;
			NullCheck(L_5);
			JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_7;
			L_7 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_5, L_6, NULL);
			String_t* L_8;
			L_8 = Extensions_Value_TisString_t_m2497E7CEFECAA73AFA2AC29B672F29E6489E1D30(L_7, Extensions_Value_TisString_t_m2497E7CEFECAA73AFA2AC29B672F29E6489E1D30_RuntimeMethod_var);
			G_B3_0 = L_8;
			goto IL_0030_1;
		}

IL_002b_1:
		{
			G_B3_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		}

IL_0030_1:
		{
			V_0 = G_B3_0;
			// if (DateTime.TryParse(formattedInputString, out dateValue))
			String_t* L_9 = V_0;
			il2cpp_codegen_runtime_class_init_inline(DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D_il2cpp_TypeInfo_var);
			bool L_10;
			L_10 = DateTime_TryParse_m6131FF17CA7636FC1F7C48DE1D4C99AB4E961E34(L_9, (&V_1), NULL);
			if (!L_10)
			{
				goto IL_0062_1;
			}
		}
		{
			// formattedInputString = JsonConvert.SerializeObject(_config[key], rawDateSettings).Replace("\"", "");
			JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_11 = __this->____config_6;
			String_t* L_12 = ___key0;
			NullCheck(L_11);
			JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_13;
			L_13 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_11, L_12, NULL);
			JsonSerializerSettings_t152F58F4E62A8349D748C945AF1699F84546D3FF* L_14 = __this->___rawDateSettings_7;
			il2cpp_codegen_runtime_class_init_inline(JsonConvert_t01281FFED14CC2AEFABB6608315D90ED5C46E0C2_il2cpp_TypeInfo_var);
			String_t* L_15;
			L_15 = JsonConvert_SerializeObject_m39CAEEF10A134A4A5A39B4A515782CD59B267459(L_13, L_14, NULL);
			NullCheck(L_15);
			String_t* L_16;
			L_16 = String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166(L_15, _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677, _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, NULL);
			V_0 = L_16;
		}

IL_0062_1:
		{
			// return formattedInputString;
			String_t* L_17 = V_0;
			V_2 = L_17;
			goto IL_006b;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0066;
		}
		throw e;
	}

CATCH_0066:
	{// begin catch(System.Object)
		// catch
		// return defaultValue;
		String_t* L_18 = ___defaultValue1;
		V_2 = L_18;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_006b;
	}// end catch (depth: 1)

IL_006b:
	{
		// }
		String_t* L_19 = V_2;
		return L_19;
	}
}
// System.Int64 Unity.RemoteConfig.RuntimeConfig::GetLong(System.String,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t RuntimeConfig_GetLong_m458EF27657A940160F2863149E926B11D76563AE (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___key0, int64_t ___defaultValue1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Extensions_Value_TisInt64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_m6F4AADD3516AF69D3B4211A1CE328B7DE1F17145_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int64_t V_0 = 0;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		// return _config[key].Value<long>();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_0 = __this->____config_6;
		String_t* L_1 = ___key0;
		NullCheck(L_0);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_2;
		L_2 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_0, L_1, NULL);
		int64_t L_3;
		L_3 = Extensions_Value_TisInt64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_m6F4AADD3516AF69D3B4211A1CE328B7DE1F17145(L_2, Extensions_Value_TisInt64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_m6F4AADD3516AF69D3B4211A1CE328B7DE1F17145_RuntimeMethod_var);
		V_0 = L_3;
		goto IL_0019;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0014;
		}
		throw e;
	}

CATCH_0014:
	{// begin catch(System.Object)
		// catch
		// return defaultValue;
		int64_t L_4 = ___defaultValue1;
		V_0 = L_4;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0019;
	}// end catch (depth: 1)

IL_0019:
	{
		// }
		int64_t L_5 = V_0;
		return L_5;
	}
}
// System.Boolean Unity.RemoteConfig.RuntimeConfig::HasKey(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RuntimeConfig_HasKey_m66A04634486D673F8A41B1CA143A7C0F4BA85FDE (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___key0, const RuntimeMethod* method) 
{
	{
		// if(_config == null)
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_0 = __this->____config_6;
		if (L_0)
		{
			goto IL_000a;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_000a:
	{
		// return _config[key] == null ? false : true;
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_1 = __this->____config_6;
		String_t* L_2 = ___key0;
		NullCheck(L_1);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_3;
		L_3 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_1, L_2, NULL);
		if (!L_3)
		{
			goto IL_001a;
		}
	}
	{
		return (bool)1;
	}

IL_001a:
	{
		return (bool)0;
	}
}
// System.String[] Unity.RemoteConfig.RuntimeConfig::GetKeys()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* RuntimeConfig_GetKeys_mF6F5B5977426E1C7EB901C9CAFF7C966F48F11BB (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_Select_TisJProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4_TisString_t_m928103D228A7FFCA8F8751874BA290AB9FD067B3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_ToArray_TisString_t_mCD2BC789CBFF834E06F00948FC47E15E720936DC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_U3CGetKeysU3Eb__30_0_m26AE8D3356D22C9291C1D6D154052615CD230AE5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* V_0 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879* G_B2_0 = NULL;
	RuntimeObject* G_B2_1 = NULL;
	Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879* G_B1_0 = NULL;
	RuntimeObject* G_B1_1 = NULL;
	try
	{// begin try (depth: 1)
		{
			// return _config.Properties().Select(prop => prop.Name).ToArray<string>();
			JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_0 = __this->____config_6;
			NullCheck(L_0);
			RuntimeObject* L_1;
			L_1 = JObject_Properties_mC40EABB282AF596A0730D5D0EA3E6A584C2FBC2A(L_0, NULL);
			il2cpp_codegen_runtime_class_init_inline(U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var);
			Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879* L_2 = ((U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var))->___U3CU3E9__30_0_1;
			Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879* L_3 = L_2;
			G_B1_0 = L_3;
			G_B1_1 = L_1;
			if (L_3)
			{
				G_B2_0 = L_3;
				G_B2_1 = L_1;
				goto IL_002a_1;
			}
		}
		{
			il2cpp_codegen_runtime_class_init_inline(U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var);
			U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9* L_4 = ((U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var))->___U3CU3E9_0;
			Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879* L_5 = (Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879*)il2cpp_codegen_object_new(Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879_il2cpp_TypeInfo_var);
			NullCheck(L_5);
			Func_2__ctor_mB93DBC8D0BDC9C65A0227565BE84A583D35EBBE3(L_5, L_4, (intptr_t)((void*)U3CU3Ec_U3CGetKeysU3Eb__30_0_m26AE8D3356D22C9291C1D6D154052615CD230AE5_RuntimeMethod_var), NULL);
			Func_2_tBCC30F25C9CD2807ACAE54010A7329FB594FC879* L_6 = L_5;
			((U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var))->___U3CU3E9__30_0_1 = L_6;
			Il2CppCodeGenWriteBarrier((void**)(&((U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var))->___U3CU3E9__30_0_1), (void*)L_6);
			G_B2_0 = L_6;
			G_B2_1 = G_B1_1;
		}

IL_002a_1:
		{
			RuntimeObject* L_7;
			L_7 = Enumerable_Select_TisJProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4_TisString_t_m928103D228A7FFCA8F8751874BA290AB9FD067B3(G_B2_1, G_B2_0, Enumerable_Select_TisJProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4_TisString_t_m928103D228A7FFCA8F8751874BA290AB9FD067B3_RuntimeMethod_var);
			StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_8;
			L_8 = Enumerable_ToArray_TisString_t_mCD2BC789CBFF834E06F00948FC47E15E720936DC(L_7, Enumerable_ToArray_TisString_t_mCD2BC789CBFF834E06F00948FC47E15E720936DC_RuntimeMethod_var);
			V_0 = L_8;
			goto IL_0041;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0037;
		}
		throw e;
	}

CATCH_0037:
	{// begin catch(System.Object)
		// catch
		// return new string[0];
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_9 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var)), (uint32_t)0);
		V_0 = L_9;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0041;
	}// end catch (depth: 1)

IL_0041:
	{
		// }
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_10 = V_0;
		return L_10;
	}
}
// System.String Unity.RemoteConfig.RuntimeConfig::GetJson(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RuntimeConfig_GetJson_m5544A318C762AD18B82CD457C10DFBC6A8D379A5 (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___key0, String_t* ___defaultValue1, const RuntimeMethod* method) 
{
	String_t* V_0 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		// return _config[key].ToString();
		JObject_t22BBBA7A90517B7E66E8C9D8D16DE84CB5054DE1* L_0 = __this->____config_6;
		String_t* L_1 = ___key0;
		NullCheck(L_0);
		JToken_tFD7D9015F3F97A09AD93E439ACE894D12C06E8B3* L_2;
		L_2 = JObject_get_Item_m889A29E8FCEA531AF829407F208DD05F0108C50B(L_0, L_1, NULL);
		NullCheck(L_2);
		String_t* L_3;
		L_3 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_2);
		V_0 = L_3;
		goto IL_0019;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0014;
		}
		throw e;
	}

CATCH_0014:
	{// begin catch(System.Object)
		// catch
		// return defaultValue;
		String_t* L_4 = ___defaultValue1;
		V_0 = L_4;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0019;
	}// end catch (depth: 1)

IL_0019:
	{
		// }
		String_t* L_5 = V_0;
		return L_5;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Unity.RemoteConfig.RuntimeConfig/<>c::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__cctor_m826B4A5C2FD7D06ED94C4BB4A6D010AD12AC70D2 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9* L_0 = (U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9*)il2cpp_codegen_object_new(U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CU3Ec__ctor_m055552C37E5ECFA5A898DE4DE579920B133EAD34(L_0, NULL);
		((U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var))->___U3CU3E9_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9_il2cpp_TypeInfo_var))->___U3CU3E9_0), (void*)L_0);
		return;
	}
}
// System.Void Unity.RemoteConfig.RuntimeConfig/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m055552C37E5ECFA5A898DE4DE579920B133EAD34 (U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.String Unity.RemoteConfig.RuntimeConfig/<>c::<GetKeys>b__30_0(Newtonsoft.Json.Linq.JProperty)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* U3CU3Ec_U3CGetKeysU3Eb__30_0_m26AE8D3356D22C9291C1D6D154052615CD230AE5 (U3CU3Ec_t8D427915A877C886F1040C66BBBA2D6D4A1B89D9* __this, JProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4* ___prop0, const RuntimeMethod* method) 
{
	{
		// return _config.Properties().Select(prop => prop.Name).ToArray<string>();
		JProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4* L_0 = ___prop0;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = JProperty_get_Name_m96280838000C5E193121125A503BA9108DB707CA_inline(L_0, NULL);
		return L_1;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ConfigManagerImpl_SetPlayerIdentityToken_m8485CA0DD7AE0E95B8FF3B8BCB08A62A0446A1B2_inline (ConfigManagerImpl_tB45922D0B10A038DEA26F20FBFAE5A49201064F7* __this, String_t* ___identityToken0, const RuntimeMethod* method) 
{
	{
		// _playerIdentityToken = identityToken;
		String_t* L_0 = ___identityToken0;
		__this->____playerIdentityToken_3 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____playerIdentityToken_3), (void*)L_0);
		// }
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* UnityWebRequestAsyncOperation_get_webRequest_mF67D15420C7C1C4DCA1BD6F839048A0542998BC3_inline (UnityWebRequestAsyncOperation_t14BE94558FF3A2CFC2EFBE2511A3A88252042B8C* __this, const RuntimeMethod* method) 
{
	{
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0 = __this->___U3CwebRequestU3Ek__BackingField_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* RCUnityWebRequest_get__unityWebRequest_mC72B3194900598C3B52D4F1B4FD44920E30D99D4_inline (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, const RuntimeMethod* method) 
{
	{
		// UnityWebRequest _unityWebRequest { get; set; }
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0 = __this->___U3C_unityWebRequestU3Ek__BackingField_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool UnityWebRequest_get_disposeUploadHandlerOnDispose_m909CC9BEACAC26C87F44AA957B8F5E5CD10F5761_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->___U3CdisposeUploadHandlerOnDisposeU3Ek__BackingField_7;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityWebRequest_set_disposeUploadHandlerOnDispose_mFE16234F005357FECF4A45F842D17C0C52B7CA6E_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, bool ___value0, const RuntimeMethod* method) 
{
	{
		bool L_0 = ___value0;
		__this->___U3CdisposeUploadHandlerOnDisposeU3Ek__BackingField_7 = L_0;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RCUnityWebRequest_set__unityWebRequest_m7D0EA20714CEA31EC9033AD41B64EABC892B3D2F_inline (RCUnityWebRequest_tC099C4A55CA09E5407412CB063EEB8A961F3AB26* __this, UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* ___value0, const RuntimeMethod* method) 
{
	{
		// UnityWebRequest _unityWebRequest { get; set; }
		UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* L_0 = ___value0;
		__this->___U3C_unityWebRequestU3Ek__BackingField_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3C_unityWebRequestU3Ek__BackingField_0), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool UnityWebRequest_get_disposeCertificateHandlerOnDispose_m5BF6519F2982ABA7912948690570F7729EDF25E9_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->___U3CdisposeCertificateHandlerOnDisposeU3Ek__BackingField_5;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityWebRequest_set_disposeCertificateHandlerOnDispose_m5EFCAF91A547716C4ACA5FB546E991B79E3D0E2A_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, bool ___value0, const RuntimeMethod* method) 
{
	{
		bool L_0 = ___value0;
		__this->___U3CdisposeCertificateHandlerOnDisposeU3Ek__BackingField_5 = L_0;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool UnityWebRequest_get_disposeDownloadHandlerOnDispose_mA5E23BB2B931F6EF089C732D0E56E1B7F9FC1C54_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->___U3CdisposeDownloadHandlerOnDisposeU3Ek__BackingField_6;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityWebRequest_set_disposeDownloadHandlerOnDispose_m1BF640E233D231F8C0333864C0FE5D9E1DC2E7C6_inline (UnityWebRequest_t6233B8E22992FC2364A831C1ACB033EF3260C39F* __this, bool ___value0, const RuntimeMethod* method) 
{
	{
		bool L_0 = ___value0;
		__this->___U3CdisposeDownloadHandlerOnDisposeU3Ek__BackingField_6 = L_0;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeConfig_set_origin_m6C14486843F6D9FF1EF6C632048897C7B99C6433_inline (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, int32_t ___value0, const RuntimeMethod* method) 
{
	{
		// public ConfigOrigin origin { get; internal set; }
		int32_t L_0 = ___value0;
		__this->___U3CoriginU3Ek__BackingField_0 = L_0;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeConfig_set_environmentId_mF086880C01CA1AEBBE02455AE3776D5D037ADFA4_inline (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___value0, const RuntimeMethod* method) 
{
	{
		// public string environmentId { get; set; }
		String_t* L_0 = ___value0;
		__this->___U3CenvironmentIdU3Ek__BackingField_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CenvironmentIdU3Ek__BackingField_1), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeConfig_set_assignmentId_mD20089BCB060198D1BD6DB4C06EB3DFCCBABE510_inline (RuntimeConfig_tA2C4BB2D69723C631888F6BBF2999712F3A1FA99* __this, String_t* ___value0, const RuntimeMethod* method) 
{
	{
		// public string assignmentId { get; set; }
		String_t* L_0 = ___value0;
		__this->___U3CassignmentIdU3Ek__BackingField_2 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CassignmentIdU3Ek__BackingField_2), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* JProperty_get_Name_m96280838000C5E193121125A503BA9108DB707CA_inline (JProperty_t1B8E99236F2BD537EC4A7A63ACDB60D7C709C5F4* __this, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = __this->____name_21;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = (RuntimeObject*)__this->____current_3;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Func_3_Invoke_mC786FD8356E25F147BEF4CF07A587720613A2C12_gshared_inline (Func_3_tFCEB9D8CEAECBF6D0AD5440F96C6F9010270CE79* __this, RuntimeObject* ___arg10, RuntimeObject* ___arg21, const RuntimeMethod* method) 
{
	typedef bool (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	return ((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___arg10, ___arg21, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964 Func_1_Invoke_mDD4D76DE063CBA57F374C98C27A50E8B72AE3BD5_gshared_inline (Func_1_t2A08DEC58BFB76B9DDF49BCF555A3342127229B5* __this, const RuntimeMethod* method) 
{
	typedef RequestHeaderTuple_tB43F780BC075D9381269BAA2EE8C1CB184649964 (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	return ((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_m496875C3D21245101D0AC44B050159FC1FBFB390_gshared_inline (Action_1_tC2D217474BBE2A65D82360D31EFE006D9C0DFE9E* __this, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871 ___obj0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, ConfigResponse_tB2D3114F84BA90687237C8849411D2633AEFC871, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___obj0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_mD6472FA27D28B9AE64A0FEF796C72ABBC2420EBF_gshared_inline (Enumerator_t65CC956745B1180C04CE6C6910FB27C5F32BB9FF* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = (RuntimeObject*)__this->____currentKey_3;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Key_mBD8EA7557C27E6956F2AF29DA3F7499B2F51A282_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = (RuntimeObject*)__this->___key_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = (RuntimeObject*)__this->___value_1;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Nullable_1_GetValueOrDefault_m26287DBB36429B2E2FBCB3F96F439248F8CAA8BB_gshared_inline (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = (int32_t)__this->___value_1;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mB1F55188CDD50D6D725D41F55D2F2540CD15FB20_gshared_inline (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = (bool)__this->___hasValue_0;
		return L_0;
	}
}
