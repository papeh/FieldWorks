<?xml version='1.0' encoding='utf-8'?>
<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>

<xsl:import href="copy.xsl" />

<xsl:output method='xml' version='1.0' indent='yes'/>

<xsl:strip-space elements="*" />

<xsl:template match="widget[@id = 'kridHelpAboutDlg']">
	<widget class="{@class}" id="{@id}">
		<xsl:apply-templates select="property" />
		<signal name="close" handler="on_dialog_close" last_modification_time="Fri, 15 Sep 2006 20:52:53 GMT"/>
		<signal name="response" handler="on_dialog_response" last_modification_time="Fri, 15 Sep 2006 20:53:02 GMT"/>
		<signal name="delete_event" handler="on_dialog_delete_event" last_modification_time="Fri, 15 Sep 2006 20:53:39 GMT"/>
		<child internal-child="vbox">			<widget class="GtkVBox" id="dialog-vbox2">				<property name="visible">True</property>				<property name="homogeneous">False</property>				<property name="spacing">0</property>				<child internal-child="action_area">					<widget class="GtkHButtonBox" id="dialog-action_area2">						<property name="visible">True</property>						<property name="layout_style">GTK_BUTTONBOX_END</property>						<child>							<widget class="GtkButton" id="kctidOk">								<property name="visible">True</property>								<property name="can_default">True</property>								<property name="can_focus">True</property>								<property name="label">gtk-ok</property>								<property name="use_stock">True</property>								<property name="relief">GTK_RELIEF_NORMAL</property>								<property name="focus_on_click">True</property>								<property name="response_id">-5</property>								<signal name="clicked" handler="on_kctidOk_clicked" last_modification_time="Thu, 07 Sep 2006 21:39:25 GMT"/>
							</widget>						</child>					</widget>					<packing>						<property name="padding">0</property>						<property name="expand">False</property>						<property name="fill">True</property>						<property name="pack_type">GTK_PACK_END</property>					</packing>				</child>
				<child>
					<widget class="{child/widget/@class}" id="{child/widget/@id}">
						<xsl:apply-templates select="child/widget/property" />
						<xsl:apply-templates select="child/widget/child" />
					</widget>
					<packing>	  					<property name="padding">0</property>	  					<property name="expand">True</property>	  					<property name="fill">True</property>					</packing>
				</child>			</widget>
		</child>
	</widget>
</xsl:template>

<xsl:template match="child[widget/@id = 'kctidOk']">
	<xsl:if test="not(ancestor::widget[@id = 'kridHelpAboutDlg'])">
		<xsl:copy-of select="." />
	</xsl:if>
</xsl:template>

<xsl:template match="widget[@id = 'kridHelpAboutDlg']//widget[@class = 'GtkImage']">
	<widget class="{@class}" id="{@id}">
		<property name="pixbuf">
			<xsl:text>HelpAbout.bmp</xsl:text>
		</property>
		<xsl:apply-templates select="property" />
	</widget>
</xsl:template>

</xsl:stylesheet>
