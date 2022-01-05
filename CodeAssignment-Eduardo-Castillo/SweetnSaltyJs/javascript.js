let count = 1;
let sweetnSalty=0;
let salty=0;
let sweet=0;

let consoleLine = "";


while (count <= 1000) {
    //The while loop is for counting to 1000, the for loop is for printing in groups of 20
    for (let i = 0; i < 20; i++) {


        // if/else decide between three cases, divisible by 5, divisible by 3 or by none
        if (count % 5 == 0) {
            if (count % 3 == 0)//Check if it is also divisible by 3
            {
                consoleLine += "sweet’nSalty";
                sweetnSalty++;
            }
            else {
                consoleLine += "salty ";
                salty++;
            }
        }
        else if (count % 3 == 0) {
            consoleLine += "sweet ";
            sweet++;
        }
        else {
            consoleLine += count + " ";
        }       
        count++;

    }//End for loop


    console.log(consoleLine);//Print a line to the console
    consoleLine = ""; //clear for the next time loop

console.log(' ');   
}//End while loop



console.log();
console.log("------------------------------------------------------------------------");
console.log(`Sweets: ${sweet}      Salties: ${salty}       Sweet’nSalties: ${sweetnSalty}`);