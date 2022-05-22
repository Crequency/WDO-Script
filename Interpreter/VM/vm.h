#include <bits/stdc++.h>

// Copyright (c) Catrol 2022-present.
// ALL RIGHTS RESERVED.
// Author:   Dynesshely/Catrol
// E-Mail:   catrol@qq.com
// Date:     2022-05-22

namespace wdo_vm{
    struct row{
        public:
            std::bitset<8>* memory;
            int length;
            inline void init(int len){
                memory = new std::bitset<8>[len];
                length = len;
            }
            inline void set(int value){
                for(int i = 0; i < length; ++ i)
                    memory[i] = value;
            }
            inline void dispose(){
                delete[] memory;
                memory = nullptr;
            }
    };

    struct var_values{
        public:
            row* values;
            int length;
            inline void init(int len){
                values = new row[len];
                length = len;
            }
            inline void dispose(){
                delete[] values;
                values = nullptr;
            }
    };

    struct var_ids{
        //TODO: 一颗字母树, 定位标识符的ID, 叶节点存储ID, 路径为字符

    };
}









