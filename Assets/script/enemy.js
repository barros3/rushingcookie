var target : Transform; // Alvo do inimigo
var moveSpeed = 50; // velocidade do movimento
var rotationSpeed = 15; //velocidade da rotaçao
var range : float= 3f;
var range2 : float= 3f;
var stop : float= 1;
var myTransform : Transform; // o atual transform do inimigo
function Awake()
{
myTransform = transform; //cache transform para acesso facil
}
function Start()
{
target = GameObject.FindWithTag("Player").transform; // alvo que sera persseguido
}
function Update () {
//rotacionar e olhar pro jogador
var distance = Vector3.Distance(myTransform.position, target.position);
if (distance<=range2 && distance>=range){
myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
}
else if(distance<=range && distance>stop){
//mover-se para o jogador
myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
}
else if (distance<=stop) {
myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
}

}