# 2024-01-02 See https://pnltoen.tistory.com/ for details

def addingMetadata():
	occurrences = scene.findByProperty('Name', '.*') #씬 전체에 있는 파트의 occurrences를 리스트로 받음
	metadataComponents = scene.getComponentByOccurrence(occurrences, scene.ComponentType.Metadata) #메타데이터가 없는 경우 0 반환
	metadataDefinitions = scene.getMetadatasDefinitions(metadataComponents) #전체 메타데이터

	for occurrence, definition in zip(occurrences, metadataDefinitions):
		print(f'{scene.getNodeName(occurrence)} contains {len(definition)} metadata')
		if len(definition) == 0:
			metadata = scene.addComponent(occurrence, scene.ComponentType.Metadata)
			scene.addMetadata(metadata, "Author", "pnltoen")
		else:
			metadata = scene.getComponent(occurrence, scene.ComponentType.Metadata)
			scene.addMetadata(metadata, "Author", "pnltoen")
			for propValue in definition:
				print(f'{propValue.name}:{propValue.value}')
				
def getEntityproperties():
	entity = 3
	#a = core.getProperty(entity, "Transform") #getProperty
	#a = core.setProperty(entity, "Transform") #setProperty
	a = core.listProperties(3)
	print(a)
	
#addingMetadata()
#getEntityproperties()