using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using DragonArchiver.Core.Models;
using DragonArchiver.Core.Utils;
using Newtonsoft.Json;

namespace DragonArchiver.Core.Services;

public class ContentListProviderService
{
    public List<MagicItem>? GetItems()
    {
        return JsonListReader.GetJsonList(new MagicItem(), Resources.magicitems);
    }
}
