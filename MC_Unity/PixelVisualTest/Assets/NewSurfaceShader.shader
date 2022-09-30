Shader "Example"
{
    Properties
    {
        _Color("Color", Color) = (1, 1, 1, 1)
    }
        SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // �C���X�^���V���O�p��pragma
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                // �C���X�^���XID�𒸓_���Ƃ��Ď󂯎��
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
            };

            half4 _Color;

            v2f vert(appdata v)
            {
                v2f o;

                // �C���X�^���XID�����Ɉʒu��X�P�[���𔽉f
                UNITY_SETUP_INSTANCE_ID(v);

                o.vertex = UnityObjectToClipPos(v.vertex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                return _Color;
            }
            ENDCG
        }
    }
}
