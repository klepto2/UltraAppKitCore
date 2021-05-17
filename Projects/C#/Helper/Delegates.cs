using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

namespace UltraEngine
{
    [return:
        global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
    public delegate bool ProcessEventHandlerDelegate(System.IntPtr ev, System.IntPtr obj);

    public delegate IntPtr EntryPointHandlerDelegate(IntPtr obj);

    public static class WrapperConstants
    {
#if !DEBUG
    public const string DllPath = "UltraAppKit";
#else
        public const string DllPath = "UltraAppKit_d";
#endif
    }

    public partial class Functions
    {
        public static void ListenEvent(EventID id, Object source, Func<Event, Object, bool> callback, Object extra)
        {
            var d = new ProcessEventHandlerDelegate((ev, ptr) =>
            {
                var e = Event.FromPointer(ev);
                var o = Object.FromPointer(ptr);
                return callback(e, o);
            });

            PInvoke.ListenEvent_Internal__SWIG_0((int) id, Object.getCPtr(source), d, Object.getCPtr(extra));
        }

        public static void ListenEvent(EventID id, Object source, Func<Event, Object, bool> callback)
        {
            var d = new ProcessEventHandlerDelegate((ev, ptr) =>
            {
                var e = Event.FromPointer(ev);
                var o = Object.FromPointer(ptr);
                return callback(e, o);
            });
            PInvoke.ListenEvent_Internal__SWIG_1((int) id, Object.getCPtr(source), d);
        }

        public static Thread CreateThread(Func<Object,Object> handler, Object obj, bool start)
        {
            var d = new EntryPointHandlerDelegate((o) =>
            {
                var result = handler(obj);
                return result.ToPointer();
            });
            return new Thread(PInvoke.CreateThread_Internal__SWIG_0(d, Object.getCPtr(obj),start),true);
        }

        public static Thread CreateThread(Func<Object, Object> handler, Object obj)
        {
            var d = new EntryPointHandlerDelegate((o) =>
            {
                var result = handler(obj);
                return result.ToPointer();
            });
            return new Thread(PInvoke.CreateThread_Internal__SWIG_1(d, Object.getCPtr(obj)), true);
        }

        public static Thread CreateThread(Func<Object, Object> handler)
        {
            var d = new EntryPointHandlerDelegate((o) =>
            {
                var result = handler(null);
                var resultPtr = result.ToPointer();
                return resultPtr;
            });
            return new Thread(PInvoke.CreateThread_Internal__SWIG_2(d), true);
        }
    }
}



