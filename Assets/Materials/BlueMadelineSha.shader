Shader"Assets/BlueMadelineShader"
{
    Properties
    {
        _MainTexture("Texture", 2D) = "white" {}
        _Color("Color", Color) = (1,1,1,1)
    }

    SubShader
    {
        Pass
        {
            CGPROGRAM
            
            #pragma vertex vertexFunc

            ENDCG
        }
    }

}