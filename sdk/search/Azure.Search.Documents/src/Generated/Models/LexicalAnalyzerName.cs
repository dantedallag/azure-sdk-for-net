// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines the names of all text analyzers supported by the search engine. </summary>
    public readonly partial struct LexicalAnalyzerName : IEquatable<LexicalAnalyzerName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LexicalAnalyzerName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LexicalAnalyzerName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ArMicrosoftValue = "ar.microsoft";
        private const string ArLuceneValue = "ar.lucene";
        private const string HyLuceneValue = "hy.lucene";
        private const string BnMicrosoftValue = "bn.microsoft";
        private const string EuLuceneValue = "eu.lucene";
        private const string BgMicrosoftValue = "bg.microsoft";
        private const string BgLuceneValue = "bg.lucene";
        private const string CaMicrosoftValue = "ca.microsoft";
        private const string CaLuceneValue = "ca.lucene";
        private const string ZhHansMicrosoftValue = "zh-Hans.microsoft";
        private const string ZhHansLuceneValue = "zh-Hans.lucene";
        private const string ZhHantMicrosoftValue = "zh-Hant.microsoft";
        private const string ZhHantLuceneValue = "zh-Hant.lucene";
        private const string HrMicrosoftValue = "hr.microsoft";
        private const string CsMicrosoftValue = "cs.microsoft";
        private const string CsLuceneValue = "cs.lucene";
        private const string DaMicrosoftValue = "da.microsoft";
        private const string DaLuceneValue = "da.lucene";
        private const string NlMicrosoftValue = "nl.microsoft";
        private const string NlLuceneValue = "nl.lucene";
        private const string EnMicrosoftValue = "en.microsoft";
        private const string EnLuceneValue = "en.lucene";
        private const string EtMicrosoftValue = "et.microsoft";
        private const string FiMicrosoftValue = "fi.microsoft";
        private const string FiLuceneValue = "fi.lucene";
        private const string FrMicrosoftValue = "fr.microsoft";
        private const string FrLuceneValue = "fr.lucene";
        private const string GlLuceneValue = "gl.lucene";
        private const string DeMicrosoftValue = "de.microsoft";
        private const string DeLuceneValue = "de.lucene";
        private const string ElMicrosoftValue = "el.microsoft";
        private const string ElLuceneValue = "el.lucene";
        private const string GuMicrosoftValue = "gu.microsoft";
        private const string HeMicrosoftValue = "he.microsoft";
        private const string HiMicrosoftValue = "hi.microsoft";
        private const string HiLuceneValue = "hi.lucene";
        private const string HuMicrosoftValue = "hu.microsoft";
        private const string HuLuceneValue = "hu.lucene";
        private const string IsMicrosoftValue = "is.microsoft";
        private const string IdMicrosoftValue = "id.microsoft";
        private const string IdLuceneValue = "id.lucene";
        private const string GaLuceneValue = "ga.lucene";
        private const string ItMicrosoftValue = "it.microsoft";
        private const string ItLuceneValue = "it.lucene";
        private const string JaMicrosoftValue = "ja.microsoft";
        private const string JaLuceneValue = "ja.lucene";
        private const string KnMicrosoftValue = "kn.microsoft";
        private const string KoMicrosoftValue = "ko.microsoft";
        private const string KoLuceneValue = "ko.lucene";
        private const string LvMicrosoftValue = "lv.microsoft";
        private const string LvLuceneValue = "lv.lucene";
        private const string LtMicrosoftValue = "lt.microsoft";
        private const string MlMicrosoftValue = "ml.microsoft";
        private const string MsMicrosoftValue = "ms.microsoft";
        private const string MrMicrosoftValue = "mr.microsoft";
        private const string NbMicrosoftValue = "nb.microsoft";
        private const string NoLuceneValue = "no.lucene";
        private const string FaLuceneValue = "fa.lucene";
        private const string PlMicrosoftValue = "pl.microsoft";
        private const string PlLuceneValue = "pl.lucene";
        private const string PtBrMicrosoftValue = "pt-BR.microsoft";
        private const string PtBrLuceneValue = "pt-BR.lucene";
        private const string PtPtMicrosoftValue = "pt-PT.microsoft";
        private const string PtPtLuceneValue = "pt-PT.lucene";
        private const string PaMicrosoftValue = "pa.microsoft";
        private const string RoMicrosoftValue = "ro.microsoft";
        private const string RoLuceneValue = "ro.lucene";
        private const string RuMicrosoftValue = "ru.microsoft";
        private const string RuLuceneValue = "ru.lucene";
        private const string SrCyrillicMicrosoftValue = "sr-cyrillic.microsoft";
        private const string SrLatinMicrosoftValue = "sr-latin.microsoft";
        private const string SkMicrosoftValue = "sk.microsoft";
        private const string SlMicrosoftValue = "sl.microsoft";
        private const string EsMicrosoftValue = "es.microsoft";
        private const string EsLuceneValue = "es.lucene";
        private const string SvMicrosoftValue = "sv.microsoft";
        private const string SvLuceneValue = "sv.lucene";
        private const string TaMicrosoftValue = "ta.microsoft";
        private const string TeMicrosoftValue = "te.microsoft";
        private const string ThMicrosoftValue = "th.microsoft";
        private const string ThLuceneValue = "th.lucene";
        private const string TrMicrosoftValue = "tr.microsoft";
        private const string TrLuceneValue = "tr.lucene";
        private const string UkMicrosoftValue = "uk.microsoft";
        private const string UrMicrosoftValue = "ur.microsoft";
        private const string ViMicrosoftValue = "vi.microsoft";
        private const string StandardLuceneValue = "standard.lucene";
        private const string StandardAsciiFoldingLuceneValue = "standardasciifolding.lucene";
        private const string KeywordValue = "keyword";
        private const string PatternValue = "pattern";
        private const string SimpleValue = "simple";
        private const string StopValue = "stop";
        private const string WhitespaceValue = "whitespace";

        /// <summary> Microsoft analyzer for Arabic. </summary>
        public static LexicalAnalyzerName ArMicrosoft { get; } = new LexicalAnalyzerName(ArMicrosoftValue);
        /// <summary> Lucene analyzer for Arabic. </summary>
        public static LexicalAnalyzerName ArLucene { get; } = new LexicalAnalyzerName(ArLuceneValue);
        /// <summary> Lucene analyzer for Armenian. </summary>
        public static LexicalAnalyzerName HyLucene { get; } = new LexicalAnalyzerName(HyLuceneValue);
        /// <summary> Microsoft analyzer for Bangla. </summary>
        public static LexicalAnalyzerName BnMicrosoft { get; } = new LexicalAnalyzerName(BnMicrosoftValue);
        /// <summary> Lucene analyzer for Basque. </summary>
        public static LexicalAnalyzerName EuLucene { get; } = new LexicalAnalyzerName(EuLuceneValue);
        /// <summary> Microsoft analyzer for Bulgarian. </summary>
        public static LexicalAnalyzerName BgMicrosoft { get; } = new LexicalAnalyzerName(BgMicrosoftValue);
        /// <summary> Lucene analyzer for Bulgarian. </summary>
        public static LexicalAnalyzerName BgLucene { get; } = new LexicalAnalyzerName(BgLuceneValue);
        /// <summary> Microsoft analyzer for Catalan. </summary>
        public static LexicalAnalyzerName CaMicrosoft { get; } = new LexicalAnalyzerName(CaMicrosoftValue);
        /// <summary> Lucene analyzer for Catalan. </summary>
        public static LexicalAnalyzerName CaLucene { get; } = new LexicalAnalyzerName(CaLuceneValue);
        /// <summary> Microsoft analyzer for Chinese (Simplified). </summary>
        public static LexicalAnalyzerName ZhHansMicrosoft { get; } = new LexicalAnalyzerName(ZhHansMicrosoftValue);
        /// <summary> Lucene analyzer for Chinese (Simplified). </summary>
        public static LexicalAnalyzerName ZhHansLucene { get; } = new LexicalAnalyzerName(ZhHansLuceneValue);
        /// <summary> Microsoft analyzer for Chinese (Traditional). </summary>
        public static LexicalAnalyzerName ZhHantMicrosoft { get; } = new LexicalAnalyzerName(ZhHantMicrosoftValue);
        /// <summary> Lucene analyzer for Chinese (Traditional). </summary>
        public static LexicalAnalyzerName ZhHantLucene { get; } = new LexicalAnalyzerName(ZhHantLuceneValue);
        /// <summary> Microsoft analyzer for Croatian. </summary>
        public static LexicalAnalyzerName HrMicrosoft { get; } = new LexicalAnalyzerName(HrMicrosoftValue);
        /// <summary> Microsoft analyzer for Czech. </summary>
        public static LexicalAnalyzerName CsMicrosoft { get; } = new LexicalAnalyzerName(CsMicrosoftValue);
        /// <summary> Lucene analyzer for Czech. </summary>
        public static LexicalAnalyzerName CsLucene { get; } = new LexicalAnalyzerName(CsLuceneValue);
        /// <summary> Microsoft analyzer for Danish. </summary>
        public static LexicalAnalyzerName DaMicrosoft { get; } = new LexicalAnalyzerName(DaMicrosoftValue);
        /// <summary> Lucene analyzer for Danish. </summary>
        public static LexicalAnalyzerName DaLucene { get; } = new LexicalAnalyzerName(DaLuceneValue);
        /// <summary> Microsoft analyzer for Dutch. </summary>
        public static LexicalAnalyzerName NlMicrosoft { get; } = new LexicalAnalyzerName(NlMicrosoftValue);
        /// <summary> Lucene analyzer for Dutch. </summary>
        public static LexicalAnalyzerName NlLucene { get; } = new LexicalAnalyzerName(NlLuceneValue);
        /// <summary> Microsoft analyzer for English. </summary>
        public static LexicalAnalyzerName EnMicrosoft { get; } = new LexicalAnalyzerName(EnMicrosoftValue);
        /// <summary> Lucene analyzer for English. </summary>
        public static LexicalAnalyzerName EnLucene { get; } = new LexicalAnalyzerName(EnLuceneValue);
        /// <summary> Microsoft analyzer for Estonian. </summary>
        public static LexicalAnalyzerName EtMicrosoft { get; } = new LexicalAnalyzerName(EtMicrosoftValue);
        /// <summary> Microsoft analyzer for Finnish. </summary>
        public static LexicalAnalyzerName FiMicrosoft { get; } = new LexicalAnalyzerName(FiMicrosoftValue);
        /// <summary> Lucene analyzer for Finnish. </summary>
        public static LexicalAnalyzerName FiLucene { get; } = new LexicalAnalyzerName(FiLuceneValue);
        /// <summary> Microsoft analyzer for French. </summary>
        public static LexicalAnalyzerName FrMicrosoft { get; } = new LexicalAnalyzerName(FrMicrosoftValue);
        /// <summary> Lucene analyzer for French. </summary>
        public static LexicalAnalyzerName FrLucene { get; } = new LexicalAnalyzerName(FrLuceneValue);
        /// <summary> Lucene analyzer for Galician. </summary>
        public static LexicalAnalyzerName GlLucene { get; } = new LexicalAnalyzerName(GlLuceneValue);
        /// <summary> Microsoft analyzer for German. </summary>
        public static LexicalAnalyzerName DeMicrosoft { get; } = new LexicalAnalyzerName(DeMicrosoftValue);
        /// <summary> Lucene analyzer for German. </summary>
        public static LexicalAnalyzerName DeLucene { get; } = new LexicalAnalyzerName(DeLuceneValue);
        /// <summary> Microsoft analyzer for Greek. </summary>
        public static LexicalAnalyzerName ElMicrosoft { get; } = new LexicalAnalyzerName(ElMicrosoftValue);
        /// <summary> Lucene analyzer for Greek. </summary>
        public static LexicalAnalyzerName ElLucene { get; } = new LexicalAnalyzerName(ElLuceneValue);
        /// <summary> Microsoft analyzer for Gujarati. </summary>
        public static LexicalAnalyzerName GuMicrosoft { get; } = new LexicalAnalyzerName(GuMicrosoftValue);
        /// <summary> Microsoft analyzer for Hebrew. </summary>
        public static LexicalAnalyzerName HeMicrosoft { get; } = new LexicalAnalyzerName(HeMicrosoftValue);
        /// <summary> Microsoft analyzer for Hindi. </summary>
        public static LexicalAnalyzerName HiMicrosoft { get; } = new LexicalAnalyzerName(HiMicrosoftValue);
        /// <summary> Lucene analyzer for Hindi. </summary>
        public static LexicalAnalyzerName HiLucene { get; } = new LexicalAnalyzerName(HiLuceneValue);
        /// <summary> Microsoft analyzer for Hungarian. </summary>
        public static LexicalAnalyzerName HuMicrosoft { get; } = new LexicalAnalyzerName(HuMicrosoftValue);
        /// <summary> Lucene analyzer for Hungarian. </summary>
        public static LexicalAnalyzerName HuLucene { get; } = new LexicalAnalyzerName(HuLuceneValue);
        /// <summary> Microsoft analyzer for Icelandic. </summary>
        public static LexicalAnalyzerName IsMicrosoft { get; } = new LexicalAnalyzerName(IsMicrosoftValue);
        /// <summary> Microsoft analyzer for Indonesian (Bahasa). </summary>
        public static LexicalAnalyzerName IdMicrosoft { get; } = new LexicalAnalyzerName(IdMicrosoftValue);
        /// <summary> Lucene analyzer for Indonesian. </summary>
        public static LexicalAnalyzerName IdLucene { get; } = new LexicalAnalyzerName(IdLuceneValue);
        /// <summary> Lucene analyzer for Irish. </summary>
        public static LexicalAnalyzerName GaLucene { get; } = new LexicalAnalyzerName(GaLuceneValue);
        /// <summary> Microsoft analyzer for Italian. </summary>
        public static LexicalAnalyzerName ItMicrosoft { get; } = new LexicalAnalyzerName(ItMicrosoftValue);
        /// <summary> Lucene analyzer for Italian. </summary>
        public static LexicalAnalyzerName ItLucene { get; } = new LexicalAnalyzerName(ItLuceneValue);
        /// <summary> Microsoft analyzer for Japanese. </summary>
        public static LexicalAnalyzerName JaMicrosoft { get; } = new LexicalAnalyzerName(JaMicrosoftValue);
        /// <summary> Lucene analyzer for Japanese. </summary>
        public static LexicalAnalyzerName JaLucene { get; } = new LexicalAnalyzerName(JaLuceneValue);
        /// <summary> Microsoft analyzer for Kannada. </summary>
        public static LexicalAnalyzerName KnMicrosoft { get; } = new LexicalAnalyzerName(KnMicrosoftValue);
        /// <summary> Microsoft analyzer for Korean. </summary>
        public static LexicalAnalyzerName KoMicrosoft { get; } = new LexicalAnalyzerName(KoMicrosoftValue);
        /// <summary> Lucene analyzer for Korean. </summary>
        public static LexicalAnalyzerName KoLucene { get; } = new LexicalAnalyzerName(KoLuceneValue);
        /// <summary> Microsoft analyzer for Latvian. </summary>
        public static LexicalAnalyzerName LvMicrosoft { get; } = new LexicalAnalyzerName(LvMicrosoftValue);
        /// <summary> Lucene analyzer for Latvian. </summary>
        public static LexicalAnalyzerName LvLucene { get; } = new LexicalAnalyzerName(LvLuceneValue);
        /// <summary> Microsoft analyzer for Lithuanian. </summary>
        public static LexicalAnalyzerName LtMicrosoft { get; } = new LexicalAnalyzerName(LtMicrosoftValue);
        /// <summary> Microsoft analyzer for Malayalam. </summary>
        public static LexicalAnalyzerName MlMicrosoft { get; } = new LexicalAnalyzerName(MlMicrosoftValue);
        /// <summary> Microsoft analyzer for Malay (Latin). </summary>
        public static LexicalAnalyzerName MsMicrosoft { get; } = new LexicalAnalyzerName(MsMicrosoftValue);
        /// <summary> Microsoft analyzer for Marathi. </summary>
        public static LexicalAnalyzerName MrMicrosoft { get; } = new LexicalAnalyzerName(MrMicrosoftValue);
        /// <summary> Microsoft analyzer for Norwegian (Bokmål). </summary>
        public static LexicalAnalyzerName NbMicrosoft { get; } = new LexicalAnalyzerName(NbMicrosoftValue);
        /// <summary> Lucene analyzer for Norwegian. </summary>
        public static LexicalAnalyzerName NoLucene { get; } = new LexicalAnalyzerName(NoLuceneValue);
        /// <summary> Lucene analyzer for Persian. </summary>
        public static LexicalAnalyzerName FaLucene { get; } = new LexicalAnalyzerName(FaLuceneValue);
        /// <summary> Microsoft analyzer for Polish. </summary>
        public static LexicalAnalyzerName PlMicrosoft { get; } = new LexicalAnalyzerName(PlMicrosoftValue);
        /// <summary> Lucene analyzer for Polish. </summary>
        public static LexicalAnalyzerName PlLucene { get; } = new LexicalAnalyzerName(PlLuceneValue);
        /// <summary> Microsoft analyzer for Portuguese (Brazil). </summary>
        public static LexicalAnalyzerName PtBrMicrosoft { get; } = new LexicalAnalyzerName(PtBrMicrosoftValue);
        /// <summary> Lucene analyzer for Portuguese (Brazil). </summary>
        public static LexicalAnalyzerName PtBrLucene { get; } = new LexicalAnalyzerName(PtBrLuceneValue);
        /// <summary> Microsoft analyzer for Portuguese (Portugal). </summary>
        public static LexicalAnalyzerName PtPtMicrosoft { get; } = new LexicalAnalyzerName(PtPtMicrosoftValue);
        /// <summary> Lucene analyzer for Portuguese (Portugal). </summary>
        public static LexicalAnalyzerName PtPtLucene { get; } = new LexicalAnalyzerName(PtPtLuceneValue);
        /// <summary> Microsoft analyzer for Punjabi. </summary>
        public static LexicalAnalyzerName PaMicrosoft { get; } = new LexicalAnalyzerName(PaMicrosoftValue);
        /// <summary> Microsoft analyzer for Romanian. </summary>
        public static LexicalAnalyzerName RoMicrosoft { get; } = new LexicalAnalyzerName(RoMicrosoftValue);
        /// <summary> Lucene analyzer for Romanian. </summary>
        public static LexicalAnalyzerName RoLucene { get; } = new LexicalAnalyzerName(RoLuceneValue);
        /// <summary> Microsoft analyzer for Russian. </summary>
        public static LexicalAnalyzerName RuMicrosoft { get; } = new LexicalAnalyzerName(RuMicrosoftValue);
        /// <summary> Lucene analyzer for Russian. </summary>
        public static LexicalAnalyzerName RuLucene { get; } = new LexicalAnalyzerName(RuLuceneValue);
        /// <summary> Microsoft analyzer for Serbian (Cyrillic). </summary>
        public static LexicalAnalyzerName SrCyrillicMicrosoft { get; } = new LexicalAnalyzerName(SrCyrillicMicrosoftValue);
        /// <summary> Microsoft analyzer for Serbian (Latin). </summary>
        public static LexicalAnalyzerName SrLatinMicrosoft { get; } = new LexicalAnalyzerName(SrLatinMicrosoftValue);
        /// <summary> Microsoft analyzer for Slovak. </summary>
        public static LexicalAnalyzerName SkMicrosoft { get; } = new LexicalAnalyzerName(SkMicrosoftValue);
        /// <summary> Microsoft analyzer for Slovenian. </summary>
        public static LexicalAnalyzerName SlMicrosoft { get; } = new LexicalAnalyzerName(SlMicrosoftValue);
        /// <summary> Microsoft analyzer for Spanish. </summary>
        public static LexicalAnalyzerName EsMicrosoft { get; } = new LexicalAnalyzerName(EsMicrosoftValue);
        /// <summary> Lucene analyzer for Spanish. </summary>
        public static LexicalAnalyzerName EsLucene { get; } = new LexicalAnalyzerName(EsLuceneValue);
        /// <summary> Microsoft analyzer for Swedish. </summary>
        public static LexicalAnalyzerName SvMicrosoft { get; } = new LexicalAnalyzerName(SvMicrosoftValue);
        /// <summary> Lucene analyzer for Swedish. </summary>
        public static LexicalAnalyzerName SvLucene { get; } = new LexicalAnalyzerName(SvLuceneValue);
        /// <summary> Microsoft analyzer for Tamil. </summary>
        public static LexicalAnalyzerName TaMicrosoft { get; } = new LexicalAnalyzerName(TaMicrosoftValue);
        /// <summary> Microsoft analyzer for Telugu. </summary>
        public static LexicalAnalyzerName TeMicrosoft { get; } = new LexicalAnalyzerName(TeMicrosoftValue);
        /// <summary> Microsoft analyzer for Thai. </summary>
        public static LexicalAnalyzerName ThMicrosoft { get; } = new LexicalAnalyzerName(ThMicrosoftValue);
        /// <summary> Lucene analyzer for Thai. </summary>
        public static LexicalAnalyzerName ThLucene { get; } = new LexicalAnalyzerName(ThLuceneValue);
        /// <summary> Microsoft analyzer for Turkish. </summary>
        public static LexicalAnalyzerName TrMicrosoft { get; } = new LexicalAnalyzerName(TrMicrosoftValue);
        /// <summary> Lucene analyzer for Turkish. </summary>
        public static LexicalAnalyzerName TrLucene { get; } = new LexicalAnalyzerName(TrLuceneValue);
        /// <summary> Microsoft analyzer for Ukrainian. </summary>
        public static LexicalAnalyzerName UkMicrosoft { get; } = new LexicalAnalyzerName(UkMicrosoftValue);
        /// <summary> Microsoft analyzer for Urdu. </summary>
        public static LexicalAnalyzerName UrMicrosoft { get; } = new LexicalAnalyzerName(UrMicrosoftValue);
        /// <summary> Microsoft analyzer for Vietnamese. </summary>
        public static LexicalAnalyzerName ViMicrosoft { get; } = new LexicalAnalyzerName(ViMicrosoftValue);
        /// <summary> Standard Lucene analyzer. </summary>
        public static LexicalAnalyzerName StandardLucene { get; } = new LexicalAnalyzerName(StandardLuceneValue);
        /// <summary> Standard ASCII Folding Lucene analyzer. See https://docs.microsoft.com/rest/api/searchservice/Custom-analyzers-in-Azure-Search#Analyzers. </summary>
        public static LexicalAnalyzerName StandardAsciiFoldingLucene { get; } = new LexicalAnalyzerName(StandardAsciiFoldingLuceneValue);
        /// <summary> Treats the entire content of a field as a single token. This is useful for data like zip codes, ids, and some product names. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/core/KeywordAnalyzer.html. </summary>
        public static LexicalAnalyzerName Keyword { get; } = new LexicalAnalyzerName(KeywordValue);
        /// <summary> Flexibly separates text into terms via a regular expression pattern. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/PatternAnalyzer.html. </summary>
        public static LexicalAnalyzerName Pattern { get; } = new LexicalAnalyzerName(PatternValue);
        /// <summary> Divides text at non-letters and converts them to lower case. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/core/SimpleAnalyzer.html. </summary>
        public static LexicalAnalyzerName Simple { get; } = new LexicalAnalyzerName(SimpleValue);
        /// <summary> Divides text at non-letters; Applies the lowercase and stopword token filters. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/core/StopAnalyzer.html. </summary>
        public static LexicalAnalyzerName Stop { get; } = new LexicalAnalyzerName(StopValue);
        /// <summary> An analyzer that uses the whitespace tokenizer. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/core/WhitespaceAnalyzer.html. </summary>
        public static LexicalAnalyzerName Whitespace { get; } = new LexicalAnalyzerName(WhitespaceValue);
        /// <summary> Determines if two <see cref="LexicalAnalyzerName"/> values are the same. </summary>
        public static bool operator ==(LexicalAnalyzerName left, LexicalAnalyzerName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LexicalAnalyzerName"/> values are not the same. </summary>
        public static bool operator !=(LexicalAnalyzerName left, LexicalAnalyzerName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LexicalAnalyzerName"/>. </summary>
        public static implicit operator LexicalAnalyzerName(string value) => new LexicalAnalyzerName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LexicalAnalyzerName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LexicalAnalyzerName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
