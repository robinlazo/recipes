const maxButton = document.querySelector(".max-icon");
const minButton = document.querySelector(".min-icon");
const stepNumber = document.querySelector("#steps-number");

const stepList = document.querySelector(".step-list");
const MAX_LIST = 10; const MIN_LIST = 1;
let CURRENT_NUMBER_LIST = 0;



function addInput(listsToAdd) {
    for (let i = 1; i <= listsToAdd; i++) {

        if (CURRENT_NUMBER_LIST >= MAX_LIST) break;

        CURRENT_NUMBER_LIST++;

        var list = `<li class="mb-4" id="step-${CURRENT_NUMBER_LIST}">
                        <input class="form-control" name="Steps" />
                    </li>`;
        
        stepList.innerHTML += list;
    }

    stepNumber.innerHTML = CURRENT_NUMBER_LIST;
}

function deleteInput() {
    if (CURRENT_NUMBER_LIST == MIN_LIST) return;
    let stepToDelete = document.querySelector(`#step-${CURRENT_NUMBER_LIST}`);
    stepToDelete.remove();

    CURRENT_NUMBER_LIST--;

    stepNumber.innerHTML = CURRENT_NUMBER_LIST;
}

addInput(5)

maxButton.addEventListener("click", () => addInput(1));
minButton.addEventListener("click", deleteInput);