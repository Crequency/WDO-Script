// Copyright (c) Catrol 2022-present.
// ALL RIGHTS RESERVED.
// Author:   Dynesshely/Catrol
// E-Mail:   catrol@qq.com
// Date:     2022-05-22

#include "memory.h"
#include "assembly.read.h"

namespace wdo_vm{

    struct var_values{
        public:
            wdo_memory::row* values;
            i64 length;
            inline void init(i64 len){
                values = new wdo_memory::row[len];
                length = len;
            }
            inline void dispose(){
                delete[] values;
                values = nullptr;
            }
    };

    struct var_name_node{
        public:
            char word;
            var_name_node *left, *right;
            wdo_memory::row value;
    };

    void init(), dispose();

    i32 process(i64 address, bool bit);
    i32 process(i64 address, wdo_memory::row value);

    enum operation{
        addition = 0,
        subtraction = 1,
        multiplication = 2,
        division = 3,
        _mod = 4, _and = 5,
        _or = 6, _xor = 7
    };

    i32 process(i64 address_a, i64 address_b, i64 address_c, operation opr);

    i64 find(std::string name);

    void process(std::string cmd);
}









