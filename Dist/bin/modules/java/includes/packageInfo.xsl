<?xml version="1.0" encoding="utf-8" ?>
<!--
/*
 Copyright 2006-2011 Abdulla Abdurakhmanov (abdulla@latestbit.com)
 Original sources are available at www.latestbit.com

 Licensed under the Apache License, Version 2.0 (the "License");
 you may not use this file except in compliance with the License.
 You may obtain a copy of the License at

 http://www.apache.org/licenses/LICENSE-2.0

 Unless required by applicable law or agreed to in writing, software
 distributed under the License is distributed on an "AS IS" BASIS,
 WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 See the License for the specific language governing permissions and
 limitations under the License.
 */
-->

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:xsltc="http://xml.apache.org/xalan/xsltc"
    xmlns:redirect="http://xml.apache.org/xalan/redirect"
    extension-element-prefixes="xsltc redirect"
>
    <xsl:import href="header.xsl"/>
    <xsl:import href="footer.xsl"/>
    <xsl:import href="elements.xsl"/>
    <xsl:import href="choiceFunctions.xsl"/>

    <xsl:output method="text" encoding="UTF-8" indent="no"/>
    
    <xsl:variable name="outputDirectory"><xsl:value-of select="//outputDirectory"/></xsl:variable>
    <xsl:variable name="moduleName"><xsl:value-of select="//moduleNS"/></xsl:variable>
    <xsl:variable name="tagDefault"><xsl:value-of select="//tagDefault"/></xsl:variable>

    <xsl:template name="packageInfo">
	<xsl:variable name="ident"><xsl:call-template name="doMangleIdent"><xsl:with-param name='input' select="name"/></xsl:call-template></xsl:variable>
        <!--<xsltc:output file="{$outputDirectory}/package-info.java"> -->
        <xsltc:output file="{$outputDirectory}/{$ident}.java">
        <xsl:call-template name="header"/>
        @ASN1Module ( name = "<xsl:value-of select='$ident'/>", isImplicitTags = <xsl:choose> <xsl:when test="$tagDefault = 'IMPLICIT'"> true </xsl:when> <xsl:otherwise> false </xsl:otherwise></xsl:choose> ) <!-- <xsl:call-template name="header"/>-->
        public class <xsl:value-of select='$ident'/> {
        }
        <xsl:call-template name="footer"/>
        </xsltc:output>        
    </xsl:template>
</xsl:stylesheet>
