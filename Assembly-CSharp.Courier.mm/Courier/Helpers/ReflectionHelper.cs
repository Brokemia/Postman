﻿using System;
using System.Reflection;

namespace Mod.Courier.Helpers {
    public static class ReflectionHelper {
        public static readonly BindingFlags PublicInstance = BindingFlags.Public | BindingFlags.Instance;
        public static readonly BindingFlags NonPublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;
        public static readonly BindingFlags PublicInstanceInvoke = PublicInstance | BindingFlags.InvokeMethod;
        public static readonly BindingFlags NonPublicInstanceFieldGet = NonPublicInstance | BindingFlags.GetField;
        public static readonly BindingFlags NonPublicInstanceFieldSet = NonPublicInstance | BindingFlags.SetField;
    }
}
