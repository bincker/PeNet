﻿/***********************************************************************
Copyright 2016 Stefan Hausotte

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

*************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeNet.Structures;

namespace PeNet.UnitTest.Structures
{
    [TestClass]
    public class IMAGE_RESOURCE_DIR_STRING_U_Test
    {
        [TestMethod]
        public void ImageResourceDirStringUConstructorWorks_Test()
        {
            var resourceDirStringU = new IMAGE_RESOURCE_DIR_STRING_U(RawStructures.RawResourceDirStringU, 2);
            Assert.AreEqual((uint) 0x000b, resourceDirStringU.Length);
            Assert.AreEqual("Hello World", resourceDirStringU.NameString);
        }
    }
}