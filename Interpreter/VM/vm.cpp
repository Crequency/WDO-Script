// Copyright (c) Catrol 2022-present.
// ALL RIGHTS RESERVED.
// Author:   Dynesshely/Catrol
// E-Mail:   catrol@qq.com
// Date:     2022-05-22

#include "vm.h"

namespace wdo_vm{

    std::map<std::string, i64> *identify_id;
    std::map<i64, wdo_memory::row> *id_value;

    void init(){
        identify_id = new std::map<std::string, i64>;
        id_value = new std::map<i64, wdo_memory::row>;
    }

    void dispose(){
        delete identify_id;
        identify_id = nullptr;
        delete id_value;
        id_value = nullptr;
    }

    i32 process(i64 address, bool bit){
        return 1;
    }

    i32 process(i64 address, wdo_memory::row value){
        return 1;
    }

    i64 find(std::string name){
        return identify_id->find(name)->second;
    }

    void process(std::string cmd){

    }
}
