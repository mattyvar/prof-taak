

task startTimer(){
	clearTimer(T1);
}

/*task gehaald(){
	eraseDisplay();
displayString(1, "U hebt het gehaald!");
int tijd = getTimerValue(T1);
displayString(5, "Uw tijd is: %d", tijd);
playSoundFile("Cheering");
delay(100000);
}*/

/*task ask(){
//int intar[] = {0,1,2,3,4,5,6,8,8,9,10};
int intran = random(11);
int intfake = random(11);
int intfake2 =random(11);
//Random ran = new Random;
displayBigTextLine(1, "Wat is 10 x %d ?", intran);
int answer = 10 * intran;
int fake = intfake * intfake2;
int kant = random(1);
if(kant==1){
displayBigTextLine(3, "antwoord: %d,%d", answer, fake);
}else{
displayBigTextLine(3, "antwoord: %d,%d", fake, answer);
}
//waitUntil(getButtonPress(buttonLeft) || getButtonPress(buttonRight));
waitForButtonPress();

if(getButtonPress(buttonLeft)== kant || getButtonPress(buttonRight) != kant){
setMotorSyncEncoder(motorB, motorC, 0,0,50);
delay(1000);
setMotorSyncEncoder(motorB, motorC, 0,0,0);
}else{
playSoundFile("Error");
delay(1000);
}
}*/



task main()
{

	long redValue;
	long blueValue;
	long greenValue;

	setSoundVolume(100);
	clearDebugStream();
	waitUntil(getTouchValue(S1));
	setMotorSyncEncoder(motorB, motorC, 0,0,50);
	getColorRGB(S3, redValue, greenValue, blueValue);

	while(true){
		getColorRGB(S3, redValue, greenValue, blueValue);
		if(redValue<5 && blueValue<5 && greenValue<5){
			setMotorSyncEncoder(motorB, motorC,0 ,0 ,0);
			startTask(startTimer);
			writeDebugStreamLine("Kleur is juist");
			delay(100);
			playSoundFile("Airbrake");
			delay(500);
			break;
		}//if end
	}//while end



	while(redValue<45 && blueValue<45 && greenValue<25){
		int intran = random(11);
		int intfake = random(11);
		int intfake2 =random(11);

		displayCenteredBigTextLine(1, "10 x %d ?", intran);

		int answer = 10 * intran;
		int fake = intfake * intfake2;
		int kant = random(1);

		if(kant==1){
			displayBigTextLine(6, "%d				of				%d", answer, fake);
			}else{
			displayBigTextLine(6, "%d				of				%d", fake, answer);
		}

		waitForButtonPress();

		if(getButtonPress(buttonLeft)== kant || getButtonPress(buttonRight) != kant){
			flushButtonMessages();
			setMotorSyncEncoder(motorB, motorC, 0,0,50);
			delay(1000);
			setMotorSyncEncoder(motorB, motorC, 0,0,0);
			getColorRGB(S3, redValue, greenValue, blueValue);
			writeDebugStreamLine("Kleur: %d, %d, %d",redValue, greenValue, blueValue );
			}else{
			flushButtonMessages();
			playSoundFile("Error");
			delay(1000);
		}

	}



eraseDisplay();
displayBigTextLine(1, "Finish bereikt!");
int tijd = getTimerValue(T1) / 1000;
displayBigTextLine(5, "Uw tijd is: %d", tijd);
playSoundFile("Cheering");
delay(100000);


}//main end





/*while(true){
getColorRGB(S3, redValue, greenValue, blueValue);
if(redValue>50 && blueValue>50 && greenValue>50){
playSoundFile("Cheering");
writeDebugStreamLine("Einde!");
delay(500);
break;
}else{
startTask(ask);
}//if end
}//while end*/
