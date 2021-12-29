//console.log('Howdy honey!');

//create the input element
let inputElem = document.createElement('input');
//add the element to the body
document.body.appendChild(inputElem);

//create the submit element
let submitTodo = document.createElement('button');
//add the element to the body
document.body.appendChild(submitTodo);
submitTodo.innerText = 'Submit a new Todo!'


//create the title element for the list
let title = document.createElement('h1');
//add the element to the body
document.body.appendChild(title);
title.innerText = 'Your Todos!'

//creating table
let todolist = document.createElement('ul'); //you can use `` or "" but with ` you can do str interperlation
document.body.appendChild(todolist); //appendchild is how to all html like .innerhtml
todolist.innerHTML = `<li> This is the first list item </li>`;
todolist.innerHTML += `<li class="hoverDemo"> This is the first second iten </li>`;

//you can target the unordered list
let myUl = document.querySelector('ul'); //This is getting another access to the <ul>
myUl.classList.add('ulClass');

//************************************************************************************************** */
submitTodo.addEventListener('click', (e) => {
    let newTodo = inputElem.value;
    //console.log(newTodo);
    if (newTodo == "")
    {
        alert("Can't accept emtpy value");
    }
    else if( newTodo.length > 10)
    {
        alert("Too many characters, limit is 10");
    }
    else{
        let myLi = document.createElement(`li`);
        myLi.innerText = `${newTodo}`;
        myUl.appendChild(myLi);
        inputElem.value = '';
        inputElem.focus();
    }
    
});

inputElem.addEventListener('keypress', (e) => {
    if (e.key == 'Enter') {
        let newTodo = inputElem.value;
        let myLi = document.createElement(`li`);
        myLi.innerText = `${newTodo}`;
        myUl.appendChild(myLi);
        inputElem.value = '';
        inputElem.focus();    
    }
});

let inputElem2 = document.createElement('input');
document.body.appendChild(inputElem2);

let ChangeTitle = document.createElement('button');
document.body.appendChild(ChangeTitle);
ChangeTitle.innerText = 'Change List Title';


ChangeTitle.addEventListener('click', (e) => {
  let newTitle = inputElem2.value;
  title.innerText = newTitle;

});

//******************************************************************************************************************************* */


document.body.addEventListener('click', (e) => {
    console.log("The body clicke event was triggered")
});

//deleting an item on the list
//put an event listener on the ul
todolist.addEventListener('click', (event) => {
    //console.log(event.target);
    event.stopPropagation(); //this will stop the emission of events going up the hierarchy 
    event.target.remove();
    //event.target.parentNode.innerText = 'this is the parent of the element';
});

