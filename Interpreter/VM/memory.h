// Copyright (c) Catrol 2022-present.
// ALL RIGHTS RESERVED.
// Author:   Dynesshely/Catrol
// E-Mail:   catrol@qq.com
// Date:     2022-05-22

#include <bits/stdc++.h>

typedef __int32 i32;
typedef __int64 i64;

namespace wdo_memory{

    struct row{
    public:
        std::bitset<8>* memory;
        i64 length;
        inline void init(i64 len){
            memory = new std::bitset<8>[len];
            length = len;
        }
        inline void set(int value){
            for(i64 i = 0; i < length; ++ i)
                memory[i] = value;
        }
        inline void dispose(){
            delete[] memory;
            memory = nullptr;
        }
    };

}