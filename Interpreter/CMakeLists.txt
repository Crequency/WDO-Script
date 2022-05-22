cmake_minimum_required(VERSION 3.22)
project(Interpreter)

set(CMAKE_CXX_STANDARD 23)

add_executable(Interpreter
        main.cpp
        VM/memory.h
        VM/vm.h VM/vm.cpp
        VM/assembly.read.h VM/assembly.read.cpp
)
