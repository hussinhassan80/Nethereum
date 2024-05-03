using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Nethereum.Contracts.Standards.ERC2535Diamond.DiamondCutFacet.ContractDefinition
{
    public partial class DiamondCutFacetDeployment : DiamondCutFacetDeploymentBase
    {
        public DiamondCutFacetDeployment() : base(BYTECODE) { }
        public DiamondCutFacetDeployment(string byteCode) : base(byteCode) { }
    }

    public class DiamondCutFacetDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561000f575f80fd5b506115808061001d5f395ff3fe608060405234801561000f575f80fd5b5060043610610029575f3560e01c80631f931c1c1461002d575b5f80fd5b61004061003b366004610fd3565b610042565b005b61004a61009a565b610093610057858761110d565b8484848080601f0160208091040260200160405190810160405280939291908181526020018383808284375f9201919091525061013592505050565b5050505050565b7fc8fcad8db84d3cc18b4c41d551ea0ee66dd599cde068d998e57d5e09332c1320546001600160a01b03166100cd610336565b6001600160a01b0316146101335760405162461bcd60e51b815260206004820152602260248201527f4c69624469616d6f6e643a204d75737420626520636f6e7472616374206f776e60448201526132b960f11b60648201526084015b60405180910390fd5b565b5f5b83518110156102eb575f8482815181106101535761015361123f565b60200260200101516020015190505f600281111561017357610173611253565b81600281111561018557610185611253565b036101d2576101cd85838151811061019f5761019f61123f565b60200260200101515f01518684815181106101bc576101bc61123f565b60200260200101516040015161038f565b6102e2565b60018160028111156101e6576101e6611253565b0361022e576101cd8583815181106102005761020061123f565b60200260200101515f015186848151811061021d5761021d61123f565b6020026020010151604001516105e1565b600281600281111561024257610242611253565b0361028a576101cd85838151811061025c5761025c61123f565b60200260200101515f01518684815181106102795761027961123f565b60200260200101516040015161085c565b60405162461bcd60e51b815260206004820152602760248201527f4c69624469616d6f6e644375743a20496e636f727265637420466163657443756044820152663a20b1ba34b7b760c91b606482015260840161012a565b50600101610137565b507f8faa70878671ccd212d20771b795c50af8fd3ff6cf27f4bde57e5d4de0aeb67383838360405161031f939291906112b4565b60405180910390a16103318282610969565b505050565b5f303303610389575f80368080601f0160208091040260200160405190810160405280939291908181526020018383808284375f920191909152505050503601516001600160a01b0316915061038c9050565b50335b90565b5f8151116103af5760405162461bcd60e51b815260040161012a906113b2565b5f805160206114df8339815191526001600160a01b0383166103e35760405162461bcd60e51b815260040161012a906113fd565b6001600160a01b0383165f9081526001820160205260408120549061ffff821690036104865761042b8460405180606001604052806024815260200161152760249139610b76565b6002820180546001600160a01b0386165f81815260018087016020908152604083208201805461ffff191661ffff90961695909517909455845490810185559381529190912090910180546001600160a01b03191690911790555b5f5b8351811015610093575f8482815181106104a4576104a461123f565b6020908102919091018101516001600160e01b031981165f908152918690526040909120549091506001600160a01b031680156105415760405162461bcd60e51b815260206004820152603560248201527f4c69624469616d6f6e644375743a2043616e2774206164642066756e6374696f6044820152746e207468617420616c72656164792065786973747360581b606482015260840161012a565b6001600160a01b0387165f8181526001878101602090815260408084208054938401815584528184206008840401805463ffffffff60079095166004026101000a948502191660e089901c94909402939093179092556001600160e01b031986168352889052902080546001600160b01b031916909117600160a01b61ffff871602179055836105d08161145d565b945050600190920191506104889050565b5f8151116106015760405162461bcd60e51b815260040161012a906113b2565b5f805160206114df8339815191526001600160a01b0383166106355760405162461bcd60e51b815260040161012a906113fd565b6001600160a01b0383165f9081526001820160205260408120549061ffff821690036106d85761067d8460405180606001604052806024815260200161152760249139610b76565b6002820180546001600160a01b0386165f81815260018087016020908152604083208201805461ffff191661ffff90961695909517909455845490810185559381529190912090910180546001600160a01b03191690911790555b5f5b8351811015610093575f8482815181106106f6576106f661123f565b6020908102919091018101516001600160e01b031981165f908152918690526040909120549091506001600160a01b0390811690871681036107a05760405162461bcd60e51b815260206004820152603860248201527f4c69624469616d6f6e644375743a2043616e2774207265706c6163652066756e60448201527f6374696f6e20776974682073616d652066756e6374696f6e0000000000000000606482015260840161012a565b6107aa8183610b97565b6001600160e01b031982165f81815260208781526040808320805461ffff60a01b1916600160a01b61ffff8b16021781556001600160a01b038c168085526001808c0185529285208054938401815585528385206008840401805463ffffffff60079095166004026101000a948502191660e08a901c94909402939093179092559390925287905281546001600160a01b0319161790558361084b8161145d565b945050600190920191506106da9050565b5f81511161087c5760405162461bcd60e51b815260040161012a906113b2565b5f805160206114df8339815191526001600160a01b038316156109005760405162461bcd60e51b815260206004820152603660248201527f4c69624469616d6f6e644375743a2052656d6f76652066616365742061646472604482015275657373206d757374206265206164647265737328302960501b606482015260840161012a565b5f5b8251811015610963575f83828151811061091e5761091e61123f565b6020908102919091018101516001600160e01b031981165f908152918590526040909120549091506001600160a01b03166109598183610b97565b5050600101610902565b50505050565b6001600160a01b0382166109f0578051156109ec5760405162461bcd60e51b815260206004820152603c60248201527f4c69624469616d6f6e644375743a205f696e697420697320616464726573732860448201527f3029206275745f63616c6c64617461206973206e6f7420656d70747900000000606482015260840161012a565b5050565b5f815111610a665760405162461bcd60e51b815260206004820152603d60248201527f4c69624469616d6f6e644375743a205f63616c6c6461746120697320656d707460448201527f7920627574205f696e6974206973206e6f742061646472657373283029000000606482015260840161012a565b6001600160a01b0382163014610a9857610a98826040518060600160405280602881526020016114ff60289139610b76565b5f80836001600160a01b031683604051610ab2919061147d565b5f60405180830381855af49150503d805f8114610aea576040519150601f19603f3d011682016040523d82523d5f602084013e610aef565b606091505b5090925090508115155f0361096357805115610b1f578060405162461bcd60e51b815260040161012a9190611498565b60405162461bcd60e51b815260206004820152602660248201527f4c69624469616d6f6e644375743a205f696e69742066756e6374696f6e2072656044820152651d995c9d195960d21b606482015260840161012a565b813b81816109635760405162461bcd60e51b815260040161012a9190611498565b5f805160206114df8339815191526001600160a01b038316610c215760405162461bcd60e51b815260206004820152603760248201527f4c69624469616d6f6e644375743a2043616e27742072656d6f76652066756e6360448201527f74696f6e207468617420646f65736e2774206578697374000000000000000000606482015260840161012a565b306001600160a01b03841603610c905760405162461bcd60e51b815260206004820152602e60248201527f4c69624469616d6f6e644375743a2043616e27742072656d6f766520696d6d7560448201526d3a30b1363290333ab731ba34b7b760911b606482015260840161012a565b6001600160e01b031982165f90815260208281526040808320546001600160a01b0387168452600180860190935290832054600160a01b90910461ffff169291610cd9916114b1565b9050808214610dc2576001600160a01b0385165f9081526001840160205260408120805483908110610d0d57610d0d61123f565b5f91825260208083206008830401546001600160a01b038a168452600188019091526040909220805460079092166004026101000a90920460e01b925082919085908110610d5d57610d5d61123f565b5f91825260208083206008830401805463ffffffff60079094166004026101000a938402191660e09590951c929092029390931790556001600160e01b031992909216825284905260409020805461ffff60a01b1916600160a01b61ffff8516021790555b6001600160a01b0385165f9081526001840160205260409020805480610dea57610dea6114ca565b5f828152602080822060085f1990940193840401805463ffffffff600460078716026101000a0219169055919092556001600160e01b0319861682528490526040812080546001600160b01b03191690558190036100935760028301545f90610e55906001906114b1565b6001600160a01b0387165f90815260018087016020526040909120015490915061ffff16808214610f10575f856002018381548110610e9657610e9661123f565b5f918252602090912001546002870180546001600160a01b039092169250829184908110610ec657610ec661123f565b5f91825260208083209190910180546001600160a01b0319166001600160a01b0394851617905592909116815260018781019092526040902001805461ffff191661ffff83161790555b84600201805480610f2357610f236114ca565b5f828152602080822083015f1990810180546001600160a01b03191690559092019092556001600160a01b03891682526001878101909152604090912001805461ffff1916905550505050505050565b80356001600160a01b0381168114610f89575f80fd5b919050565b5f8083601f840112610f9e575f80fd5b50813567ffffffffffffffff811115610fb5575f80fd5b602083019150836020828501011115610fcc575f80fd5b9250929050565b5f805f805f60608688031215610fe7575f80fd5b853567ffffffffffffffff80821115610ffe575f80fd5b818801915088601f830112611011575f80fd5b81358181111561101f575f80fd5b8960208260051b8501011115611033575f80fd5b6020830197508096505061104960208901610f73565b9450604088013591508082111561105e575f80fd5b5061106b88828901610f8e565b969995985093965092949392505050565b634e487b7160e01b5f52604160045260245ffd5b6040516060810167ffffffffffffffff811182821017156110b3576110b361107c565b60405290565b604051601f8201601f1916810167ffffffffffffffff811182821017156110e2576110e261107c565b604052919050565b5f67ffffffffffffffff8211156111035761110361107c565b5060051b60200190565b5f61111f61111a846110ea565b6110b9565b83815260208082019190600586811b86013681111561113c575f80fd5b865b8181101561123257803567ffffffffffffffff8082111561115d575f80fd5b818a01915060608236031215611171575f80fd5b611179611090565b61118283610f73565b81528683013560038110611194575f80fd5b81880152604083810135838111156111aa575f80fd5b939093019236601f8501126111bd575f80fd5b833592506111cd61111a846110ea565b83815292871b840188019288810190368511156111e8575f80fd5b948901945b8486101561121b5785356001600160e01b03198116811461120c575f80fd5b825294890194908901906111ed565b91830191909152508852505094830194830161113e565b5092979650505050505050565b634e487b7160e01b5f52603260045260245ffd5b634e487b7160e01b5f52602160045260245ffd5b5f5b83811015611281578181015183820152602001611269565b50505f910152565b5f81518084526112a0816020860160208601611267565b601f01601f19169290920160200192915050565b5f6060808301606084528087518083526080925060808601915060808160051b8701016020808b015f5b8481101561138257898403607f19018652815180516001600160a01b0316855283810151898601906003811061132257634e487b7160e01b5f52602160045260245ffd5b868601526040918201519186018a9052815190819052908401905f90898701905b8083101561136d5783516001600160e01b0319168252928601926001929092019190860190611343565b509785019795505050908201906001016112de565b50506001600160a01b038a169088015286810360408801526113a48189611289565b9a9950505050505050505050565b6020808252602b908201527f4c69624469616d6f6e644375743a204e6f2073656c6563746f727320696e206660408201526a1858d95d081d1bc818dd5d60aa1b606082015260800190565b6020808252602c908201527f4c69624469616d6f6e644375743a204164642066616365742063616e2774206260408201526b65206164647265737328302960a01b606082015260800190565b634e487b7160e01b5f52601160045260245ffd5b5f61ffff80831681810361147357611473611449565b6001019392505050565b5f825161148e818460208701611267565b9190910192915050565b602081525f6114aa6020830184611289565b9392505050565b818103818111156114c4576114c4611449565b92915050565b634e487b7160e01b5f52603160045260245ffdfec8fcad8db84d3cc18b4c41d551ea0ee66dd599cde068d998e57d5e09332c131c4c69624469616d6f6e644375743a205f696e6974206164647265737320686173206e6f20636f64654c69624469616d6f6e644375743a204e657720666163657420686173206e6f20636f6465a2646970667358221220406654a8fd811dc03865cd78419f1794d16a08b2dbc2757a348f9ab70782cc8a64736f6c63430008170033";
        public DiamondCutFacetDeploymentBase() : base(BYTECODE) { }
        public DiamondCutFacetDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class DiamondCutFunction : DiamondCutFunctionBase { }

    [Function("diamondCut")]
    public class DiamondCutFunctionBase : FunctionMessage
    {
        [Parameter("tuple[]", "_diamondCut", 1)]
        public virtual List<FacetCut> DiamondCut { get; set; }
        [Parameter("address", "_init", 2)]
        public virtual string Init { get; set; }
        [Parameter("bytes", "_calldata", 3)]
        public virtual byte[] Calldata { get; set; }
    }

    public partial class DiamondCutEventDTO : DiamondCutEventDTOBase { }

    [Event("DiamondCut")]
    public class DiamondCutEventDTOBase : IEventDTO
    {
        [Parameter("tuple[]", "_diamondCut", 1, false )]
        public virtual List<FacetCut> DiamondCut { get; set; }
        [Parameter("address", "_init", 2, false )]
        public virtual string Init { get; set; }
        [Parameter("bytes", "_calldata", 3, false )]
        public virtual byte[] Calldata { get; set; }
    }
}