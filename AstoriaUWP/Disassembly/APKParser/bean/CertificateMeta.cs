﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalvikUWPCSharp.Disassembly.APKParser.bean
{
    public class CertificateMeta
    {
        /**
     * the sign algorithm name
     */
        private string signAlgorithm;

        /**
         * the signature algorithm OID string.
         * An OID is represented by a set of non-negative whole numbers separated by periods.
         * For example, the string "1.2.840.10040.4.3" identifies the SHA-1 with DSA signature algorithm defined in
         * <a href="http://www.ietf.org/rfc/rfc3279.txt">
         *     RFC 3279: Algorithms and Identifiers for the Internet X.509 Public Key Infrastructure Certificate and CRL Profile
         * </a>.
         */
        private string signAlgorithmOID;

        /**
         * the start date of the validity period.
         */
        private DateTime startDate;

        /**
         * the end date of the validity period.
         */
        private DateTime endDate;

        /**
         * certificate binary data.
         */
        private byte[] data;

        /**
         * first use base64 to encode certificate binary data, and then calculate md5 of base64b string.
         * some programs use this as the certMd5 of certificate
         */
        private string certBase64Md5;

        /**
         * use md5 to calculate certificate's certMd5.
         */
        private string certMd5;

        public byte[] getData()
        {
            return data;
        }

        public void setData(byte[] data)
        {
            this.data = data;
        }

        public string getCertBase64Md5()
        {
            return certBase64Md5;
        }

        public void setCertBase64Md5(string certBase64Md5)
        {
            this.certBase64Md5 = certBase64Md5;
        }

        public string getCertMd5()
        {
            return certMd5;
        }

        public void setCertMd5(string certMd5)
        {
            this.certMd5 = certMd5;
        }

        public string getSignAlgorithm()
        {
            return signAlgorithm;
        }

        public void setSignAlgorithm(string signAlgorithm)
        {
            this.signAlgorithm = signAlgorithm;
        }

        public DateTime getStartDate()
        {
            return startDate;
        }

        public void setStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public DateTime getEndDate()
        {
            return endDate;
        }

        public void setEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }

        public string getSignAlgorithmOID()
        {
            return signAlgorithmOID;
        }

        public void setSignAlgorithmOID(string signAlgorithmOID)
        {
            this.signAlgorithmOID = signAlgorithmOID;
        }

        public string toString()
        {
            return "signAlgorithm:\t" + signAlgorithm + '\n' +
                    "certBase64Md5:\t" + certBase64Md5 + '\n' +
                    "certMd5:\t" + certMd5;
        }

        public override string ToString()
        {
            return toString();
        }
    }
}
