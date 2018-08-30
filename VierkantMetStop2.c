task taskOne(){
displayBigTextLine(0, "Hallo Wereld");
}
task main()
{
//int buttonDownPress = getButtonPress(buttonDown);
//int buttonEnterPress = getButtonPress(buttonEnter);


int switchNumber =0;
if(getButtonPress(buttonDown) == 1){
	switchNumber = 1;
}else if(getButtonPress(buttonEnter) ==1){
switchNumber = 2;
}

switch(switchNumber){
	case 1:
	startTask(taskOne);
	break;

}


}
