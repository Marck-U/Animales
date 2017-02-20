<%@ Page Title="" Language="C#" MasterPageFile="Inicio.master" AutoEventWireup="true" CodeFile="Salud.aspx.cs" Inherits="Salud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <h2 class="center deep-orange-text">Manten tu mascota saludable</h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col s12">
            <ul class="tabs">
                <li class="tab col s3"><a href="#test1">Salud</a></li>
                <li class="tab col s3"><a href="#test2">Vacunas</a></li>
                <li class="tab col s3"><a href="#test3">Enfermedades</a></li>
                <li class="tab col s3"><a href="#test4">esterilización</a></li>
            </ul>
        </div>
        <div class="container center-align">
            <div id="test1" class="col s12">
                <p>
                    <b>
                        <p style="font-size: 22px;">Cuida su higiene:</p>
                    </b>Establece una rutina regular de alimentación; si se trata de un perro, sácalo de paseo con frecuencia para que haga sus necesidades, especialmente cuando se despierte. Si le ves caminar en círculos o gimiendo cerca de la puerta, son signos seguros de que necesita salir al exterior rápidamente. En el caso de los gatos, recuerda que ellos defecan en la arena, la cual debes cambiar cada 5 días.
                    <br />
                    <b>
                        <p style="font-size: 22px;">Dieta y ejercicio:</p>
                    </b>Son vitales para el bienestar de tu mascota, sobre todo si se trata de un perro o un gato. Al ser muy juguetones y enérgicos, debes asegurarte de que realizan el ejercicio adecuado. También es el responsable de dar al animal la nutrición que necesite desde el principio.
                   <b>
                       <p style="font-size: 22px;">Aprende a detectar enfermedades:</p>
                   </b>A menudo, puedes pensar que tu mascota no se siente bien y una rápida visita al veterinario te ayudará a confirmar que algo no marcha correctamente. Algunos síntomas son: pérdida de apetito, rechazo del agua, disminución o aumento súbito de peso, lentitud o rechazo a jugar, micciones frecuentes o escasas, heces con sangre o blandas, vómitos, salivación excesiva o respiración irregular.  
                   <b>
                       <p style="font-size: 22px;">Entrenalo:</p>
                   </b>A nadie le gusta un perro desobediente e incontrolado, por lo que al adoptarlo puedes iniciar con su entrenamiento. Una de las primeras cosas que deberás hacer es que reconozca su nombre. Utilízalo con tanta frecuencia como puedas para llamar su atención: cuando le felicites y cuando le das de comer.
                </p>
            </div>
        </div>
        <div class="container">
            <div id="test2" class="col s4">
                <p>
                    <h3 class="deep-orange-text">Calendario de vacunas:</h3>
                    Vacunas para Gatos
                    <br />
                    Edad     Vacuna<br />
                    2 meses     Triple felina<br />
                    3 meses     Triple felina y vacuna contra leucemia<br />
                    4 meses     Triple felina y vacuna contra leucemia<br />
                    6 meses     Antirrábica<br />
                    -----------------------------------------------------------------------------<br />
                    Vacunas para perros<br />
                    Edad     Vacuna<br />
                    2 meses     Séxtuple u óctuple<br />
                    3 meses     Séxtuple u óctuple<br />
                    4 meses     Séxtuple u óctuple<br />
                    6 meses     Antirrábica<br />
                    ANUAL      vacuna antirrábica /Octuple / Séxtuple<br />
                    Calendario de desparasitación<br />
                    Edad<br />
                    15 Días<br />
                    30 Días<br />
                    45 Días<br />
                    60 Días<br />
                    75 Días<br />
                    3 Meses<br />
                    4 Meses<br />
                    5 Meses<br />
                    Cada 3-4 Meses para los felinos debe ser igual
                </p>
            </div>
        </div>
        <div class="container">
            <div id="test3" class="col s12">
                <p>
                    <h3 class="center deep-orange-text">Enfermedades Perrunas</h3>
                    <b>
                        <p style="font-size: 22px;">Rabia:</p>
                    </b>Conocida y temida, la rabia es una enfermedad tremendamente letal. Se transmite a través de mordeduras, contacto directo con las mucosas o saliva. Se identifica por una violencia extrema sin provocación alguna. Existe una antirrábica que se debe administrar cuando son cachorros, pues una vez infectado, el perro se considera condenado a muerte, no existe vacuna para él.
                    <b>
                        <p style="font-size: 22px;">Epilepsia:</p>
                    </b>La epilepsia en perros es una descarga electroquímica del cerebro que puede aparecer en cualquier momento. Las crisis se repiten prácticamente durante toda la vida del perro que la sufre. Se pueden controlar los episodios mediante medicación expresa del veterinario.
                     <b>
                         <p style="font-size: 22px;">Coronavirus:</p>
                     </b>Es una enfermedad viral e infecciosa que afecta a todo tipo de perros pero en especial a cachorros aún no vacunados. Se puede detectar en el momento que vemos que el perro tiene abundante diarrea, vómitos e incluso observamos pérdida de peso. No existe vacuna para el coronavirus canino, será el veterinario quien contrarreste los síntomas que provoca la enfermedad.
                    <h3 class="center deep-orange-text">Enfermedades Gatunas</h3>
                    <b>
                        <p style="font-size: 22px;">Inmunodeficiencia felina:</p>
                    </b>Se trata de una enfermedad vírica de los gatos producida por un oncovirus, es decir se trata de un tipo de cáncer, que se transmite por contacto con fluidos corporales. Por ejemplo, en peleas de gatos suele haber alguna herida que sangra, cuando se acicalan y se lamen los unos a los otros contactan con la saliva de los demás, si comparten el arenero pueden entrar en contacto con la orina y las heces de otros gatos, una madre que amamanta a las crías si está infectada puede pasar el virus a través de la leche, entre más formas posibles de transmisión por contacto de fluidos. Esta enfermedad suele afectar más a gatitos pequeños y jóvenes. Es común en grandes colectivos de gatos como criaderos y colonias callejeras. Es una de las enfermedades más graves por su facilidad de transmisión y el alcance de los daños que causa, incluso la muerte. Se producen tumores en distintos órganos del cuerpo del felino afectado y presentan ganglios aumentados, anorexia, pérdida de peso, anemia y depresión entre más síntomas. La mejor forma de prevenir esta enfermedad viral es la vacunación y evitar que nuestro gato entre en contacto con posibles individuos ya enfermos.
                    <b>
                        <p style="font-size: 22px;">Conjuntivitis:</p>
                    </b>Los gatos son de salud ocular delicada, por eso tienen con facilidad conjuntivitis.
                   <b>
                       <p style="font-size: 22px;">Rinotraqueítis felina:</p>
                   </b>En este caso el virus que provoca esta enfermedad es un herpesvirus. El virus se aloja en las vías respiratorias ocasionando infecciones en el sistema respiratorio. Entre un 45-50% de las enfermedades respiratorias en felinos son causadas por este virus. Afecta especialmente a los gatos jóvenes no vacunados. La sintomatología encuadra fiebre, estornudos, mucosidad nasal, conjuntivitis, lagrimeo e incluso úlceras en la córnea. Se contagia por contacto con fluidos como secreciones nasales y saliva. Esta enfermedad se puede prevenir con la vacunación adecuada. No existe un tratamiento específico para esta enfermedad por lo que se tratan sus síntomas. Los felinos que sanan se convierten en portadores pues ya no padecen los síntomas pero siguen alojando al virus y pueden contagiar a otros individuos. Lo mejor es la prevención con la vacunación.
                </p>

            </div>
        </div>
        <div class="container">
            <div id="test4" class="col s12">
                <p>
                    <b>
                        <p style="font-size: 22px;">¿Qué es esterilizar?:</p>
                    </b>Un procedimiento quirúrgico por el que se impide la reproducción al animal, y puede realizarse tanto en machos (vasectomía) como en hembras (ligadura de trompas). En ambos casos se dejan intactos los órganos sexuales y el animal mantiene la conducta sexual, ya que no hay modificación de los procesos hormonales (las hembras siguen teniendo el celo).
                <b>
                    <p style="font-size: 22px;">¿Qué es castrar?:</p>
                </b>Es la extirpación quirúrgica de los órganos sexuales. Machos: testículos (castración); hembras: ovarios (Ovariectomía OV), u ovarios y útero (Ovariohisterectomía OVH). Los procesos hormonales desaparecen y el carácter del animal no sufre alteración (en machos agresivos por dominancia sexual ésta puede llegar a desaparecer). Las hembras no tienen el celo.
                <b>
                    <p style="font-size: 22px;">¿Le cambia el carácter?:</p>
                </b>Después de una castración, solamente se modifican como consecuencia directa aquellas conductas ligadas a sus hormonas, como el hecho del marcaje y la territorialidad en los machos. En muchas ocasiones, el animal sí experimenta un cambio notable de conducta al detectar el cambio en el trato que recibe de parte de su propietario, por ejemplo cuando éste se vuelve mucho más protector porque "le da pena" haberlo castrado, y le consiente cosas que antes no le consentía.
                </p>

            </div>
        </div>
    </div>
    <div class="parallax-container" style="margin-top: 2%;">

        <div class="parallax">

            <img src="image/slider6.jpg" />
        </div>
    </div>

</asp:Content>

