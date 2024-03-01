const button = document.getElementById("modal")
const buttonClose = document.getElementById("close")

const modal = document.querySelector("dialog")


button.onclick = function ()
{
    modal.showModal()
}

buttonClose.onclick = function ()
{
    modal.close()
}