Shader "Custom/XRay"
{
    Subshader
    {
        // 2000 - 2999 -> Opaque objects
        // 3000 - 3999 -> Transparent Objects
        //render after every transparent object and opaque object
        Tags { "Queue" = "Transparent+1" } // 3000 + 1

        Pass {Blend Zero One} // Make it invisible
    }
}
