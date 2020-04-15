all: build run clean
Factorial.o: Fact.cpp
	gcc -c -o Factorial.o Fact.cpp
build: Factorial.o
	gcc -o Factorial Factorial.o
run:
	Factorial.exe
clean:
	del *.o Factorial  