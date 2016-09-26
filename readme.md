StrongHTTP.CodeGen
====

Interface Generator for [StrongHTTP](https://github.com/pjc0247/StrongHTTP)

Usage
----
```cs
var g = G.Namespace("Rini.Game")
    .Service("player")
        .Get("GetProfile", "profile")
            .ReturnAsync(typeof(Profile));
            //.Return(typeof("Profile"))
            //.Return("Profile")

Console.WriteLine(g.Generate());
```

```cs
using System;

using StrongHTTP;
using StrongHTTP.Attributes;
using StrongHTTP.Attributes.Request;
using StrongHTTP.Attributes.Response;

namespace Rini.Game
{
        public interface player
        {
                [Method("GET")]
                Task<Profile> GetProfile ();
        }
}
```

TODO
----
* 리턴 타입 모델 처리
