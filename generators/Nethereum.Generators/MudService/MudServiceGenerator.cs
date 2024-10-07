using System;
using Nethereum.Generators.Core;
using Nethereum.Generators.CQS;
using Nethereum.Generators.Model;

namespace Nethereum.Generators.MudService
{
    public class MudServiceGenerator : ClassGeneratorBase<ClassTemplateBase<MudServiceModel>, MudServiceModel>
    {
        public  ContractABI ContractABI { get; }

        public MudServiceGenerator(ContractABI contractABI, string contractName, string byteCode, string @namespace, string cqsNamespace, string functionOutputNamespace, CodeGenLanguage codeGenLanguage, string mudNamespace = null)
        {
            ContractABI = contractABI;
            ClassModel = new MudServiceModel(contractABI, contractName, byteCode, @namespace, cqsNamespace, functionOutputNamespace, mudNamespace);
            ClassModel.CodeGenLanguage = codeGenLanguage;
            InitialiseTemplate(codeGenLanguage);
        }

        public void InitialiseTemplate(CodeGenLanguage codeGenLanguage)
        {
            switch (codeGenLanguage)
            {
                case CodeGenLanguage.CSharp:
                    ClassTemplate = new MudServiceCSharpTemplate(ClassModel);
                    break;
                case CodeGenLanguage.Vb:
                   // ClassTemplate = new MudServiceVbTemplate(ClassModel);
                    break;
                case CodeGenLanguage.FSharp:
                    //ClassTemplate = new MudServiceFSharpTemplate(ClassModel); 
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(codeGenLanguage), codeGenLanguage, "Code generation not implemented for this language");
            }

        }
    }
}