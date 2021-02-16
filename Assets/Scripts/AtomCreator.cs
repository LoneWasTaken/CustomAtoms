using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomCreator : MonoBehaviour
{

    public GameObject proton;
    public GameObject neutron;
    public GameObject electron;

    private GameObject atomicParent;

    public GameObject alertBackground;

    public Text inputText;

    public Text userAlertsText;

    public Text ElementDemo;
    public Text protonDemo;
    public Text neutronDemo;
    public Text electronDemo;


    
    
    string[] atomNames =
    {
        "hydrogen",
        "helium",
        "lithium",
        "beryllium",
        "boron",
        "carbon",
        "nitrogen",
        "oxygen",
        "fluorine",
        "neon",
        "sodium",
        "magnesium",
        "alumnum",
        "silicon",
        "phosphorus",
        "sulfur",
        "chlorine",
        "argon",
        "potassium",
        "calcium",
        "scandium",
        "titanium",
        "vandium",
        "chromium",
        "manganese",
        "iron",
        "cobalt",
        "nickel",
        "copper",
        "zinc",
        "gallium",
        "germanium",
        "arsenic",
        "selenium",
        "bromine",
        "krypton",
        "rubidium",
        "strontium",
        "yttrium",
        "zirconium",
        "niobium",
        "molybdenum",
        "technetium",
        "ruthenium",
        "rhodium",
        "palladium",
        "silver",
        "cadmium",
        "indium",
        "tin",
        "antimony",
        "tellerium",
        "iodine",
        "xenon",
        "caesium",
        "barium",
        "lanthanum",
        "cerium",
        "praseodymium",
        "neodymium",
        "promethium",
        "samarium",
        "europium",
        "gadolinium",
        "terubim",
        "dysprosium",
        "holmium",
        "erbium",
        "thulium",
        "ytterbium",
        "lutetium",
        "hafnium",
        "tantalum",
        "tungsten",
        "rhenium",
        "osmium",
        "iridium",
        "platinum",
        "gold",
        "mercury",
        "thallium",
        "lead",
        "bismuth",
        "polonium",
        "astatine",
        "radon",
        "francium",
        "radium",
        "actinium",
        "thorium",
        "protactinium",
        "uranium",
        "neptunium",
        "plutonium",
        "americium",
        "curium",
        "berkelium",
        "californium",
        "einstenium",
        "fermium",
        "mandelevium",
        "nobelium",
        "lawrencium",
        "rutherfordium",
        "dubnium",
        "seaborgium",
        "bohrium",
        "hassium",
        "meitnerium",
        "darmsradtium",
        "roentgenium",
        "copernicium",
        "nihonium",
        "flerovium",
        "moscovium",
        "livermorium",
        "tennessine",
        "oganesson",


    };


    Vector2Int[] elementInformation =
    {   
        new Vector2Int(1, 1),
        new Vector2Int(2, 4),
        new Vector2Int(3, 7),
        new Vector2Int(4, 9),
        new Vector2Int(5, 10),
        new Vector2Int(6, 12),
        new Vector2Int(7, 14),
        new Vector2Int(8, 16),
        new Vector2Int(9, 19),
        new Vector2Int(10, 20),
        new Vector2Int(11, 29),
        new Vector2Int(12, 24),
        new Vector2Int(13, 27),
        new Vector2Int(14, 28),
        new Vector2Int(15, 31),
        new Vector2Int(16, 32),
        new Vector2Int(17, 35),
        new Vector2Int(18, 40),
        new Vector2Int(19, 39),
        new Vector2Int(20, 40),
        new Vector2Int(21, 45),
        new Vector2Int(22, 48),
        new Vector2Int(23, 51),
        new Vector2Int(24, 52),
        new Vector2Int(25, 55),
        new Vector2Int(26, 56),
        new Vector2Int(27, 59),
        new Vector2Int(28, 59),
        new Vector2Int(29, 64),
        new Vector2Int(30, 65),
        new Vector2Int(31, 70),
        new Vector2Int(32, 73),
        new Vector2Int(33, 75),
        new Vector2Int(34, 79),
        new Vector2Int(35, 80),
        new Vector2Int(36, 84),
        new Vector2Int(37, 85),
        new Vector2Int(38, 88),
        new Vector2Int(39, 89),
        new Vector2Int(40, 91),
        new Vector2Int(41, 93),
        new Vector2Int(42, 96),
        new Vector2Int(43, 98),
        new Vector2Int(44, 101),
        new Vector2Int(45, 103),
        new Vector2Int(46, 106),
        new Vector2Int(47, 108),
        new Vector2Int(48, 112),
        new Vector2Int(49, 115),
        new Vector2Int(50, 119),
        new Vector2Int(51, 122),
        new Vector2Int(52, 128),
        new Vector2Int(53, 127),
        new Vector2Int(54, 131),
        new Vector2Int(55, 133),
        new Vector2Int(56, 137),
        new Vector2Int(57, 139),
        new Vector2Int(58, 140),
        new Vector2Int(59, 141),
        new Vector2Int(60, 144),
        new Vector2Int(61, 145),
        new Vector2Int(62, 150),
        new Vector2Int(63, 152),
        new Vector2Int(64, 157),
        new Vector2Int(65, 159),
        new Vector2Int(66, 163),
        new Vector2Int(67, 165),
        new Vector2Int(68, 167),
        new Vector2Int(69, 169),
        new Vector2Int(70, 173),
        new Vector2Int(71, 175),
        new Vector2Int(72, 178),
        new Vector2Int(73, 181),
        new Vector2Int(74, 184),
        new Vector2Int(75, 186),
        new Vector2Int(76, 190),
        new Vector2Int(77, 192),
        new Vector2Int(78, 195),
        new Vector2Int(79, 197),
        new Vector2Int(80, 201),
        new Vector2Int(81, 204),
        new Vector2Int(82, 207),
        new Vector2Int(83, 208),
        new Vector2Int(84, 209),
        new Vector2Int(85, 210),
        new Vector2Int(86, 222),
        new Vector2Int(87, 223),
        new Vector2Int(88, 226),
        new Vector2Int(89, 227),
        new Vector2Int(90, 232),
        new Vector2Int(91, 231),
        new Vector2Int(92, 238),
        new Vector2Int(93, 237),
        new Vector2Int(94, 244),
        new Vector2Int(95, 243),
        new Vector2Int(96, 247),
        new Vector2Int(97, 247),
        new Vector2Int(98, 251),
        new Vector2Int(99, 252),
        new Vector2Int(100, 257),
        new Vector2Int(101, 258),
        new Vector2Int(102, 259),
        new Vector2Int(103, 255),
        new Vector2Int(104, 267),
        new Vector2Int(105, 268),
        new Vector2Int(106, 269),
        new Vector2Int(107, 270),
        new Vector2Int(108, 277),
        new Vector2Int(109, 278),
        new Vector2Int(110, 281),
        new Vector2Int(111, 282),
        new Vector2Int(112, 285),
        new Vector2Int(113, 286),
        new Vector2Int(114, 289),
        new Vector2Int(115, 290),
        new Vector2Int(116, 293),
        new Vector2Int(117, 294),
        new Vector2Int(118, 294),


    };

    GameObject[] elementImages;


    ///string userInput = "silicon";

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {

            int arrayIndex = -1;

            for (int x = 0; x < atomNames.Length; x++)
            {
                if (inputText.text.ToLower() == atomNames[x])
                {
                    arrayIndex = x;
                    ElementDemo.text = "Element Shown: " + inputText.text.ToUpper();
                }
            }
            if(arrayIndex < 0)
            {
                userAlertsText.text = inputText.text + " was either not found or not in the list of avalable elements.";
                alertBackground.SetActive(true);
                return;
            }

            userAlertsText.text = "";
            alertBackground.SetActive(false);
            Destroy(atomicParent);
            atomicParent = new GameObject("Atomic Parent");

            for (int x = 0; x < elementInformation[arrayIndex].x; x++)
            {
                GameObject refrence = Instantiate(proton);
                refrence.transform.position = Random.insideUnitSphere * Mathf.Log(elementInformation[arrayIndex].x) / 2;
                refrence.transform.SetParent(atomicParent.transform);
                int demo = elementInformation[arrayIndex].x;
                protonDemo.text = "Number of Protons: " + demo;
            }

            int neutronCount = elementInformation[arrayIndex].y - elementInformation[arrayIndex].x;
                int nDemo = neutronCount;
                neutronDemo.text = "Number of Neutrons: " + nDemo;
            for (int x = 0; x < neutronCount; x++)
            {
                GameObject refrence = Instantiate(neutron);
                refrence.transform.position = Random.insideUnitSphere * Mathf.Log(neutronCount) / 2;
                refrence.transform.SetParent(atomicParent.transform);
            }
            for (int x = 0; x < elementInformation[arrayIndex].x; x++)
            {
                GameObject refrence = Instantiate(electron);
                refrence.transform.GetChild(0).transform.position = new Vector3(Mathf.Max(1.2f, Mathf.Log(elementInformation[arrayIndex].x)) * 2, 0, 0);
                refrence.transform.Rotate(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f));
                refrence.transform.SetParent(atomicParent.transform);
                int demo = elementInformation[arrayIndex].x;
                electronDemo.text = "Number of Electrons: " + demo;
            }

            Debug.Log("array index" + arrayIndex);
            Debug.Log(atomNames[arrayIndex]);
            Debug.Log(elementInformation[arrayIndex].x);
            Debug.Log(neutronCount);
        }
    }
}
