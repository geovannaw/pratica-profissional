using Sistema_Vendas.GControls;
using Sistema_Vendas.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas
{
    public class Form : System.Windows.Forms.Form {
        //padronização dos comportamentos do form
        public Form()
        {
            this.KeyPreview = true;
            this.KeyUp += Form_KeyUp;
            this.KeyDown += Form_KeyDown;
        }

        private void Form_KeyUp(object sender, KeyEventArgs e) //tecla ESC
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void abrirConsultaProdutos()
        {
            ConsultaProdutos consultaProdutos = new ConsultaProdutos();
            consultaProdutos.ShowDialog(); 
        }

        public void AtualizarCampoComDataPadrao(GMaskedTextBox campoTexto, out DateTime data)
        {
            string entrada = campoTexto.Texts;
            DateTime dataPadrao = new DateTime(1800, 1, 1);

            if (DateTime.TryParse(entrada, out data))
            {
                // Se a conversão for bem-sucedida, é utilizada a data convertida
                campoTexto.Texts = data.ToString("dd/MM/yyyy");
            }
            else
            {
                // Se a conversão falhar, é definida uma data padrão
                campoTexto.Texts = dataPadrao.ToString("dd/MM/yyyy");
                data = dataPadrao;
            }
        }

        public void AtualizarCampoData(DateTime data, GMaskedTextBox campoTexto)
        {
            DateTime dataPadrao = new DateTime(1800, 1, 1);
            if (data == dataPadrao)
            {
                campoTexto.Clear(); // Deixa o campo vazio
            }
            else
            {
                campoTexto.Texts = data.ToString("dd/MM/yyyy");
            }
        }


        public bool VerificarDataMenorOuIgualHoje(DateTime data, string campoNome)
        {
            if (data > DateTime.Today)
            {
                MessageBox.Show($"A data de {campoNome} não pode ser maior que a data de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool VerificaLetras(string texto)
        {
            // se o campo estiver vazio, considera-se válido
            if (string.IsNullOrWhiteSpace(texto))
                return true;

            // verificar se a string contém somente letras, espaços, acentos, ç e ponto final
            Regex regex = new Regex(@"^[a-zA-ZÀ-ü\sçÇ.]+$");

            return regex.IsMatch(texto);
        }

        public static bool VerificaLetrasSemEspaco(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return true;

            //verificar se a string contém somente letras (sem espaços)
            Regex regex = new Regex("^[a-zA-Z]+$");

            return regex.IsMatch(texto);
        }

        public static bool VerificaNumeros(string texto)
        {
            //se o campo estiver vazio, considera-se válido
            if (string.IsNullOrWhiteSpace(texto))
                return true;

            //verificar se a string contém somente números (sem espaços entre eles)
            Regex regex = new Regex("^[0-9]+$");

            return regex.IsMatch(texto);
        }

        public static bool VerificaValores(string texto)
        {
            // se o campo estiver vazio, considera-se válido
            if (string.IsNullOrWhiteSpace(texto))
                return true;

            // verificar se a string contém um valor numérico inteiro ou com vírgula e até duas casas decimais
            Regex regex = new Regex(@"^\d+,\d{0,2}$|^\d+$");

            return regex.IsMatch(texto);
        }

        public static bool VerificaPrecos(string texto)
        {
            // se o campo estiver vazio, considera-se válido
            if (string.IsNullOrWhiteSpace(texto))
                return true;

            // remover pontos e espaços (separadores de milhares)
            texto = texto.Replace(".", "").Replace(" ", "");

            // verificar se a string contém um valor numérico inteiro ou com vírgula e até duas casas decimais
            Regex regex = new Regex(@"^\d+(\,\d{0,2})?$");

            return regex.IsMatch(texto);
        }

        public static string FormataPreco(string texto)
        {
            // remover pontos e espaços (separadores de milhares)
            texto = texto.Replace(".", "").Replace(" ", "");

            if (decimal.TryParse(texto, out decimal value))
            {
                return value.ToString("N2");
            }
            else
            {
                throw new FormatException("Valor inválido.");
            }
        }

        public static bool CampoObrigatorio(string texto)
        {
            //verifica se o texto está vazio ou contém apenas espaços em branco
            return !string.IsNullOrWhiteSpace(texto);
        }

        public static bool ValidaCNPJ(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj))
            {
                return true;
            } else
            {
                // Remove caracteres não numéricos
                cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

                // Verifica se a string tem 14 caracteres (tamanho de um CNPJ)
                if (cnpj.Length != 14)
                    return false;

                // Calcula o primeiro dígito verificador
                int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma = 0;
                for (int i = 0; i < 12; i++)
                {
                    soma += int.Parse(cnpj[i].ToString()) * multiplicadores1[i];
                }
                int resto = soma % 11;
                int dv1 = resto < 2 ? 0 : 11 - resto;

                // Calcula o segundo dígito verificador
                int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                soma = 0;
                for (int i = 0; i < 13; i++)
                {
                    soma += int.Parse(cnpj[i].ToString()) * multiplicadores2[i];
                }
                resto = soma % 11;
                int dv2 = resto < 2 ? 0 : 11 - resto;

                // Verifica se os dígitos verificadores calculados são iguais aos informados
                return dv1 == int.Parse(cnpj[12].ToString()) && dv2 == int.Parse(cnpj[13].ToString());
            } 
        }

        public static bool ValidaCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                return true;
            } else
            {
                // Remove caracteres não numéricos
                cpf = cpf.Replace(".", "").Replace("-", "");

                // Verifica se a string tem 11 caracteres (tamanho de um CPF)
                if (cpf.Length != 11)
                    return false;

                // Verifica se todos os dígitos são iguais
                bool todosIguais = true;
                for (int i = 1; i < cpf.Length; i++)
                {
                    if (cpf[i] != cpf[0])
                    {
                        todosIguais = false;
                        break;
                    }
                }
                if (todosIguais)
                    return false;

                // Calcula o primeiro dígito verificador
                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) * (10 - i);
                }
                int resto = soma % 11;
                int dv1 = resto < 2 ? 0 : 11 - resto;

                // Calcula o segundo dígito verificador
                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) * (11 - i);
                }
                resto = soma % 11;
                int dv2 = resto < 2 ? 0 : 11 - resto;

                // Verifica se os dígitos verificadores calculados são iguais aos informados
                return dv1 == int.Parse(cpf[9].ToString()) && dv2 == int.Parse(cpf[10].ToString());
            }
        }

        public static bool ValidaEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return true;
            else
            {
                string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                Regex regex = new Regex(padrao);
                return regex.IsMatch(email);
            }
        }

        public static bool ValidaPis(string pis)
        {
            if (string.IsNullOrWhiteSpace(pis))
            {
                return true;
            }
            else
            {
                int[] multiplicador = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma;
                int resto;
                if (pis.Trim().Length != 11)
                    return false;
                pis = pis.Trim();
                pis = pis.Replace("-", "").Replace(".", "").PadLeft(11, '0');

                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(pis[i].ToString()) * multiplicador[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                return pis.EndsWith(resto.ToString());
            }
        }


        public static bool ValidaIE(string estado, string inscricaoEstadual)
        {
            if (string.IsNullOrEmpty(estado) || string.IsNullOrEmpty(inscricaoEstadual))
                return false;

            if (estado.Length != 2)
                return false;

            if (inscricaoEstadual.Length == 0)
                return false;

            var IE = inscricaoEstadual.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if ((IE.Trim().ToUpper() == "ISENTO"))
                return true;

            try
            {
                switch (estado.ToUpper())
                {

                    case "AC":
                        return validaAC(IE);

                    case "AL":
                        return validaAL(IE);

                    case "AM":
                        return validaAM(IE);

                    case "AP":
                        return validaAP(IE);

                    case "BA":
                        return validaBA(IE);

                    case "CE":
                        return validaCE(IE);

                    case "DF":
                        return validaDF(IE);

                    case "ES":
                        return validaES(IE);

                    case "GO":
                        return validaGO(IE);

                    case "MA":
                        return validaMA(IE);

                    case "MT":
                        return validaMT(IE);

                    case "MS":
                        return validaMS(IE);

                    case "MG":
                        return validaMG(IE);

                    case "PA":
                        return validaPA(IE);

                    case "PB":
                        return validaPB(IE);

                    case "PE":
                        return validaPE(IE);

                    case "PI":
                        return validaPI(IE);

                    case "PR":
                        return validaPR(IE);

                    case "RJ":
                        return validaRJ(IE);

                    case "RN":
                        return validaRN(IE);

                    case "RO":
                        return validaRO(IE);

                    case "RR":
                        return validaRR(IE);

                    case "RS":
                        return validaRS(IE);

                    case "SC":
                        return validaSC(IE);

                    case "SE":
                        return validaSE(IE);

                    case "SP":
                        return validaSP(IE);

                    case "TO":
                        return validaTO(IE);

                    default:
                        return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private static bool validaAC(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 13 || IE.Substring(0, 2) != "01")
                return false;

            var strBase = IE.Trim();

            if (strBase.Substring(0, 2) != "01") return false;

            var intSoma = 0;
            var intPeso = 4;
            var intValor = 0;

            for (var intPos = 1; (intPos <= 11); intPos++)
            {

                intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                if (intPeso == 1) intPeso = 9;

                intSoma += intValor * intPeso;

                intPeso--;
            }

            var intResto = (intSoma % 11);

            intSoma = 0;
            strBase = (IE.Trim() + "000000000000").Substring(0, 12);
            intPeso = 5;

            for (var intPos = 1; (intPos <= 12); intPos++)
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                if (intPeso == 1) intPeso = 9;

                intSoma += intValor * intPeso;
                intPeso--;
            }

            intResto = (intSoma % 11);
            var strDigito2 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));

            var strBase2 = (strBase.Substring(0, 12) + strDigito2);

            return (strBase2 == IE);
        }

        private static bool validaAL(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9 || IE.Substring(0, 2) != "24")
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);

            if ((strBase.Substring(0, 2) != "24")) return false;

            var intSoma = 0;
            var intPeso = 9;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {

                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                intSoma += intValor * intPeso;
                intPeso--;
            }

            intSoma = (intSoma * 10);
            var intResto = (intSoma % 11);

            var strDigito1 = ((intResto == 10) ? "0" : Convert.ToString(intResto)).Substring((((intResto == 10) ? "0" : Convert.ToString(intResto)).Length - 1));

            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;
        }

        private static bool validaAM(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9)
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;
            var intPeso = 9;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                intSoma += intValor * intPeso;
                intPeso--;
            }

            var intResto = (intSoma % 11);
            var strDigito1 = intSoma < 11 ? (11 - intSoma).ToString() : ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return (strBase2 == IE);

        }

        private static bool validaAP(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9)
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intPeso = 9;

            if (strBase.Substring(0, 2) != "03") return false;

            strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;

            int intValor;
            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                intSoma += intValor * intPeso;
                intPeso--;
            }

            var intResto = (intSoma % 11);
            intValor = (11 - intResto);

            var strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;
        }

        private static bool validaBA(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;

            if (IE.Length != 9 && IE.Length != 8)
                return false;

            var strBase = "";

            switch (IE.Length)
            {
                case 8:
                    strBase = (IE.Trim() + "00000000").Substring(0, 8);
                    break;
                case 9:
                    strBase = (IE.Trim() + "00000000").Substring(0, 9);
                    break;
            }

            var intSoma = 0;
            int intValor;
            var intPeso = 0;
            int intResto;
            var strDigito1 = "";
            var strDigito2 = "";
            var strBase2 = "";


            #region Validação 8 dígitos
            if (strBase.Length == 8)
            {

                if ((("0123458".IndexOf(strBase.Substring(0, 1), 0, StringComparison.OrdinalIgnoreCase) + 1) > 0))
                {

                    for (var intPos = 1; (intPos <= 6); intPos++)
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                        if (intPos == 1) intPeso = 7;

                        intSoma += intValor * intPeso;
                        intPeso--;
                    }


                    intResto = (intSoma % 10);
                    strDigito2 = ((intResto == 0) ? "0" : Convert.ToString((10 - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((10 - intResto))).Length - 1));


                    strBase2 = strBase.Substring(0, 7) + strDigito2;

                    if (strBase2 == IE)
                    {

                        intSoma = 0;
                        intPeso = 0;

                        for (var intPos = 1; (intPos <= 7); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                            if (intPos == 7)
                                intValor = int.Parse(strBase.Substring((intPos), 1));

                            if (intPos == 1) intPeso = 8;

                            intSoma += intValor * intPeso;
                            intPeso--;
                        }


                        intResto = (intSoma % 10);
                        strDigito1 = ((intResto == 0) ? "0" : Convert.ToString((10 - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((10 - intResto))).Length - 1));

                        strBase2 = (strBase.Substring(0, 6) + strDigito1 + strDigito2);

                        return strBase2 == IE;

                    }

                    return false;


                }


                if ((("679".IndexOf(strBase.Substring(0, 1), 0, StringComparison.OrdinalIgnoreCase) + 1) > 0))
                {

                    intSoma = 0;

                    for (var intPos = 1; (intPos <= 6); intPos++)
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                        if (intPos == 1) intPeso = 7;

                        intSoma += intValor * intPeso;
                        intPeso--;
                    }


                    intResto = (intSoma % 11);
                    strDigito2 = ((intResto == 0) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((11 - intResto))).Length - 1));


                    strBase2 = strBase.Substring(0, 7) + strDigito2;

                    if (strBase2 == IE)
                    {

                        intSoma = 0;
                        intPeso = 0;

                        for (var intPos = 1; (intPos <= 7); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                            if (intPos == 7)
                                intValor = int.Parse(strBase.Substring((intPos), 1));

                            if (intPos == 1) intPeso = 8;

                            intSoma += intValor * intPeso;
                            intPeso--;
                        }


                        intResto = (intSoma % 11);
                        strDigito1 = ((intResto == 0) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((11 - intResto))).Length - 1));

                        strBase2 = (strBase.Substring(0, 6) + strDigito1 + strDigito2);

                        return strBase2 == IE;

                    }

                    return false;

                }

            }
            #endregion


            #region Validação 9 dígitos
            if (strBase.Length == 9)
            {

                var modulo = (("0123458".IndexOf(strBase.Substring(1, 1), 0, StringComparison.OrdinalIgnoreCase) + 1) > 0) ? 10 : 11;


                intSoma = 0;


                for (var intPos = 1; (intPos <= 7); intPos++)
                {
                    intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                    if (intPos == 1) intPeso = 8;

                    intSoma += intValor * intPeso;
                    intPeso--;
                }

                intResto = (intSoma % modulo);

                if (modulo == 11)
                    strDigito2 = ((intResto == 0 || intResto == 1) ? "0" : Convert.ToString((modulo - intResto))).Substring((((intResto == 0 || intResto == 1) ? "0" : Convert.ToString((modulo - intResto))).Length - 1));
                else
                    strDigito2 = ((intResto == 0) ? "0" : Convert.ToString((modulo - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((modulo - intResto))).Length - 1));


                strBase2 = strBase.Substring(0, 8) + strDigito2;

                if (strBase2 == IE)
                {

                    intSoma = 0;
                    intPeso = 0;

                    for (var intPos = 1; (intPos <= 8); intPos++)
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                        if (intPos == 8)
                            intValor = int.Parse(strBase.Substring((intPos), 1));

                        if (intPos == 1) intPeso = 9;

                        intSoma += intValor * intPeso;
                        intPeso--;
                    }


                    intResto = (intSoma % modulo);

                    if (modulo == 11)
                        strDigito1 = ((intResto == 0 || intResto == 1) ? "0" : Convert.ToString((modulo - intResto))).Substring((((intResto == 0 || intResto == 1) ? "0" : Convert.ToString((modulo - intResto))).Length - 1));
                    else
                        strDigito1 = ((intResto == 0) ? "0" : Convert.ToString((modulo - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((modulo - intResto))).Length - 1));


                    strBase2 = (strBase.Substring(0, 7) + strDigito1 + strDigito2);

                    return strBase2 == IE;

                }

                return false;


            }
            #endregion

            return false;

        }


        private static bool validaCE(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length > 9)
                return false;

            while (IE.Length <= 8)
                IE = "0" + IE;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;
            var intValor = 0;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            intValor = (11 - intResto);

            if ((intValor > 9))
                intValor = 0;

            var strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaDF(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 13 || IE.Substring(0, 3) != "073")
                return false;

            var strBase = (IE.Trim() + "0000000000000").Substring(0, 13);

            var intSoma = 0;
            var intPeso = 2;
            var intValor = 0;

            for (var intPos = 11; (intPos >= 1); intPos = (intPos + -1))
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * intPeso);
                intSoma = (intSoma + intValor);
                intPeso = (intPeso + 1);

                if ((intPeso > 9))
                    intPeso = 2;
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 11) + strDigito1);

            intSoma = 0;
            intPeso = 2;

            for (var intPos = 12; (intPos >= 1); intPos = (intPos + -1))
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * intPeso);
                intSoma = (intSoma + intValor);
                intPeso = (intPeso + 1);

                if ((intPeso > 9))
                    intPeso = 2;
            }

            intResto = (intSoma % 11);
            var strDigito2 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            strBase2 = (strBase.Substring(0, 12) + strDigito2);

            return strBase2 == IE;
        }

        private static bool validaES(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9)
                return false;

            var strBase = IE.Trim();
            var intSoma = 0;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaGO(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9)
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);

            if ((("10,11,15".IndexOf(strBase.Substring(0, 2), 0, StringComparison.OrdinalIgnoreCase) + 1) <= 0))
                return false;

            var intSoma = 0;
            var strDigito1 = "";

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);

            switch (intResto)
            {
                case 0:
                    strDigito1 = "0";
                    break;

                case 1:
                    var intNumero = int.Parse(strBase.Substring(0, 8));
                    strDigito1 = (((intNumero >= 10103105) && (intNumero <= 10119997)) ? "1" : "0").Substring(((((intNumero >= 10103105) && (intNumero <= 10119997)) ? "1" : "0").Length - 1));
                    break;

                default:
                    strDigito1 = Convert.ToString((11 - intResto)).Substring((Convert.ToString((11 - intResto)).Length - 1));
                    break;
            }

            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;
        }

        private static bool validaMA(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9 || IE.Substring(0, 2) != "12")
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaMT(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length < 9)
                return false;

            while (IE.Length <= 11)
                IE = "0" + IE;

            var strBase = (IE.Trim() + "0000000000").Substring(0, 10);
            var intSoma = 0;
            var intPeso = 2;

            for (var intPos = 10; intPos >= 1; intPos = (intPos + -1))
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * intPeso);
                intSoma = (intSoma + intValor);
                intPeso = (intPeso + 1);

                if ((intPeso > 9))
                    intPeso = 2;
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 10) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaMS(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9 || IE.Substring(0, 2) != "28")
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaMG(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 13)
                return false;

            if (IE.Substring(0, 2).ToUpper() == "PR")
                return true;


            var strBase = (IE.Trim() + "0000000000000").Substring(0, 13);
            var strBase2 = strBase.Substring(0, 3) + "0" + strBase.Substring(3, 9);
            var intNumero = 1;

            var intSoma = 0;

            for (var intPos = 0; intPos < 12; intPos++)
            {

                if (int.Parse(strBase2.Substring(intPos, 1)) * intNumero >= 10)
                    intSoma += (int.Parse(strBase2.Substring(intPos, 1)) * intNumero) - 9;
                else
                    intSoma += int.Parse(strBase2.Substring(intPos, 1)) * intNumero;

                intNumero = intNumero + 1;

                if (intNumero == 3)
                    intNumero = 1;

            }

            intNumero = (int)((Math.Floor((Convert.ToDecimal(intSoma) + 10) / 10) * 10) - intSoma);
            if (intNumero % 10 == 0)
                intNumero = 0;

            if (intNumero != Convert.ToInt32(IE.Substring(11, 1)))
                return false;


            intNumero = 3;
            intSoma = 0;

            for (var intPos = 0; intPos < 12; intPos++)
            {

                intSoma += int.Parse(IE.Substring(intPos, 1)) * intNumero;

                intNumero = intNumero - 1;
                if (intNumero == 1)
                    intNumero = 11;

            }

            intNumero = 11 - (intSoma % 11);
            if (intNumero >= 10)
                intNumero = 0;


            return intNumero == Convert.ToInt32(IE.Substring(12, 1));

        }

        private static bool validaPA(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9 || IE.Substring(0, 2) != "15")
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaPB(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9)
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;
            int intValor;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            intValor = (11 - intResto);

            if ((intValor > 9))
                intValor = 0;

            var strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaPE(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9)
                return false;

            var strBase = (IE.Trim() + "00000000000000").Substring(0, 14);
            var intSoma = 0;
            var intPeso = 2;
            int intValor;

            for (var intPos = 7; (intPos >= 1); intPos = (intPos + -1))
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * intPeso);
                intSoma = (intSoma + intValor);
                intPeso = (intPeso + 1);

                if ((intPeso > 9))
                    intPeso = 2;
            }

            var intResto = (intSoma % 11);
            intValor = (11 - intResto);

            if ((intValor >= 10))
                intValor = 0;

            if (intValor != Convert.ToInt32(IE.Substring(7, 1)))
                return false;

            var strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
            var strBase2 = (strBase.Substring(0, 7) + strDigito1);

            if (strBase2 != IE.Substring(0, 8))
                return false;

            intSoma = 0;
            intPeso = 2;

            for (var intPos = 8; (intPos >= 1); intPos = (intPos + -1))
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * intPeso);
                intSoma = (intSoma + intValor);
                intPeso = (intPeso + 1);

                if ((intPeso > 9))
                    intPeso = 2;
            }

            intResto = (intSoma % 11);
            intValor = (11 - intResto);

            if ((intValor >= 10))
                intValor = 0;


            return intValor.ToString() == IE.Substring(8, 1);

        }

        private static bool validaPI(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9)
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaPR(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 10)
                return false;

            var strBase = (IE.Trim() + "0000000000").Substring(0, 10);
            var intSoma = 0;
            var intPeso = 2;
            int intValor;

            for (var intPos = 8; (intPos >= 1); intPos = (intPos + -1))
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * intPeso);
                intSoma = (intSoma + intValor);
                intPeso = (intPeso + 1);

                if ((intPeso > 7))
                    intPeso = 2;
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);
            intSoma = 0;
            intPeso = 2;

            for (var intPos = 9; (intPos >= 1); intPos = (intPos + -1))
            {
                intValor = int.Parse(strBase2.Substring((intPos - 1), 1));
                intValor = (intValor * intPeso);
                intSoma = (intSoma + intValor);
                intPeso = (intPeso + 1);

                if ((intPeso > 7))
                    intPeso = 2;
            }

            intResto = (intSoma % 11);
            var strDigito2 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            strBase2 = (strBase2 + strDigito2);

            return strBase2 == IE;

        }

        private static bool validaRJ(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 8)
                return false;

            var strBase = (IE.Trim() + "00000000").Substring(0, 8);
            var intSoma = 0;
            var intPeso = 2;

            for (var intPos = 7; (intPos >= 1); intPos = (intPos + -1))
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * intPeso);
                intSoma = (intSoma + intValor);
                intPeso = (intPeso + 1);

                if ((intPeso > 7))
                    intPeso = 2;
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 7) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaRN(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            var strBase = "";
            switch (IE.Length)
            {
                case 9:
                    strBase = (IE.Trim() + "000000000").Substring(0, 9);
                    break;

                case 10:
                    strBase = (IE.Trim() + "000000000").Substring(0, 10);
                    break;
            }

            var intSoma = 0;

            if ((strBase.Substring(0, 2) == "20") && strBase.Length == 9)
            {

                for (var intPos = 1; (intPos <= 8); intPos++)
                {
                    var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                    intValor = (intValor * (10 - intPos));
                    intSoma = (intSoma + intValor);
                }

                intSoma = (intSoma * 10);
                var intResto = (intSoma % 11);
                var strDigito1 = ((intResto > 9) ? "0" : Convert.ToString(intResto)).Substring((((intResto > 9) ? "0" : Convert.ToString(intResto)).Length - 1));
                var strBase2 = (strBase.Substring(0, 8) + strDigito1);

                return strBase2 == IE;

            }


            if (strBase.Length == 10)
            {
                intSoma = 0;

                for (var intPos = 1; (intPos <= 9); intPos++)
                {
                    var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                    intValor = (intValor * (11 - intPos));
                    intSoma = (intSoma + intValor);
                }

                intSoma = (intSoma * 10);
                var intResto = (intSoma % 11);
                var strDigito1 = ((intResto > 10) ? "0" : Convert.ToString(intResto)).Substring((((intResto > 10) ? "0" : Convert.ToString(intResto)).Length - 1));
                var strBase2 = (strBase.Substring(0, 9) + strDigito1);

                return strBase2 == IE;

            }

            return false;

        }

        private static bool validaRO(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 14)
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var strBase2 = strBase.Substring(3, 5);
            var intSoma = 0;
            int intValor;

            for (var intPos = 1; (intPos <= 5); intPos++)
            {
                intValor = int.Parse(strBase2.Substring((intPos - 1), 1));
                intValor = (intValor * (7 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            intValor = (11 - intResto);

            if ((intValor > 9))
                intValor = (intValor - 10);

            var strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
            strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaRR(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9 || IE.Substring(0, 2) != "24")
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = intValor * intPos;
                intSoma += intValor;
            }

            var intResto = (intSoma % 9);
            var strDigito1 = Convert.ToString(intResto).Substring((Convert.ToString(intResto).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaRS(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 10 || Convert.ToInt32(IE) > 467)
                return false;

            var strBase = (IE.Trim() + "0000000000").Substring(0, 10);
            var intSoma = 0;
            var intPeso = 2;
            var intValor = 0;

            for (var intPos = 9; (intPos >= 1); intPos = (intPos + -1))
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * intPeso);
                intSoma = (intSoma + intValor);
                intPeso = (intPeso + 1);

                if ((intPeso > 9))
                    intPeso = 2;
            }

            var intResto = (intSoma % 11);
            intValor = (11 - intResto);

            if ((intValor > 9))
                intValor = 0;

            var strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
            var strBase2 = (strBase.Substring(0, 9) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaSC(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9)
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaSE(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 9)
                return false;

            var strBase = (IE.Trim() + "000000000").Substring(0, 9);
            var intSoma = 0;
            int intValor;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            intValor = (11 - intResto);

            if ((intValor > 9))
                intValor = 0;

            var strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
            var strBase2 = (strBase.Substring(0, 8) + strDigito1);

            return strBase2 == IE;

        }

        private static bool validaSP(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            string strBase;
            string strBase2;
            int intSoma;
            int intPeso;

            if ((IE.Substring(0, 1) == "P"))
            {
                strBase = (IE.Trim() + "0000000000000").Substring(0, 13);
                intSoma = 0;
                intPeso = 1;

                for (var intPos = 1; (intPos <= 8); intPos++)
                {
                    var intValor = int.Parse(strBase.Substring((intPos), 1));
                    intValor = (intValor * intPeso);
                    intSoma = (intSoma + intValor);
                    intPeso = (intPeso + 1);

                    if ((intPeso == 2))
                        intPeso = 3;

                    if ((intPeso == 9))
                        intPeso = 10;
                }

                var intResto = (intSoma % 11);
                var strDigito1 = Convert.ToString(intResto).Substring((Convert.ToString(intResto).Length - 1));
                strBase2 = (strBase.Substring(0, 9) + (strDigito1 + strBase.Substring(10, 3)));
            }
            else
            {
                strBase = (IE.Trim() + "000000000000").Substring(0, 12);
                intSoma = 0;
                intPeso = 1;

                for (var intPos = 1; (intPos <= 8); intPos++)
                {
                    var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                    intValor = (intValor * intPeso);
                    intSoma = (intSoma + intValor);
                    intPeso = (intPeso + 1);

                    if ((intPeso == 2))
                        intPeso = 3;

                    if ((intPeso == 9))
                        intPeso = 10;
                }

                var intResto = (intSoma % 11);
                var strDigito1 = Convert.ToString(intResto).Substring((Convert.ToString(intResto).Length - 1));
                strBase2 = (strBase.Substring(0, 8) + (strDigito1 + strBase.Substring(9, 2)));
                intSoma = 0;
                intPeso = 2;

                for (var intPos = 11; (intPos >= 1); intPos = (intPos + -1))
                {
                    var intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                    intValor = (intValor * intPeso);
                    intSoma = (intSoma + intValor);
                    intPeso = (intPeso + 1);

                    if ((intPeso > 10))
                        intPeso = 2;
                }

                intResto = (intSoma % 11);
                var strDigito2 = Convert.ToString(intResto).Substring((Convert.ToString(intResto).Length - 1));
                strBase2 = (strBase2 + strDigito2);
            }

            return strBase2 == IE;

        }

        private static bool validaTO(string inscricaoEstadual)
        {

            var IE = inscricaoEstadual;
            if (IE.Length != 11 || IE.Substring(2, 2) != "01" || IE.Substring(2, 2) != "02" || IE.Substring(2, 2) != "03" || IE.Substring(2, 2) != "99")
                return false;

            var strBase = (IE.Trim() + "00000000000").Substring(0, 11);
            var strBase2 = (strBase.Substring(0, 2) + strBase.Substring(4, 6));
            var intSoma = 0;

            for (var intPos = 1; (intPos <= 8); intPos++)
            {
                var intValor = int.Parse(strBase2.Substring((intPos - 1), 1));
                intValor = (intValor * (10 - intPos));
                intSoma = (intSoma + intValor);
            }

            var intResto = (intSoma % 11);
            var strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
            strBase2 = (strBase.Substring(0, 10) + strDigito1);

            return strBase2 == IE;


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);

        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                abrirConsultaProdutos();
            }
        }
    }
}
